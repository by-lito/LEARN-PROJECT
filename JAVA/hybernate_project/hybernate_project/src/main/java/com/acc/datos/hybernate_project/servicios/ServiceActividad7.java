package com.acc.datos.hybernate_project.servicios;

import com.acc.datos.hybernate_project.pojos.*;
import com.acc.datos.hybernate_project.repositorios.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.sql.Date;
import java.util.List;
import java.util.Optional;

@Service
public class ServiceActividad7 {

    @Autowired private ProyectoRepository proyectoRepo;
    @Autowired private SedeRepository sedeRepo;
    @Autowired private ProyectoSedeRepository proyectoSedeRepo;
    @Autowired private EmpleadoRepository empleadoRepo;
    @Autowired private DatosProfesionalesRepository datosProfRepo;
    @Autowired private DepartamentoRepository departamentoRepo;

    private static final String RESET = "\u001B[0m";
    private static final String VERDE = "\u001B[32m";
    private static final String AMARILLO = "\u001B[33m";
    private static final String ROJO = "\u001B[31m";


    //@Transactional
    public void ejecutar() {
        try {
            System.out.println(AMARILLO + "Intentando guardar datos..." + RESET);

            Proyecto p1 = new Proyecto();
            p1.setNomProy("Proyecto Alfa");
            p1.setFInicio(Date.valueOf("2024-01-01"));
            proyectoRepo.save(p1);

            Proyecto p2 = new Proyecto();
            p2.setNomProy("Proyecto Beta");
            p2.setFInicio(Date.valueOf("2024-02-01"));
            proyectoRepo.save(p2);

            Optional<Sede> sedeOpt = sedeRepo.findById(1);
            if (sedeOpt.isEmpty()) {
                throw new RuntimeException("Sede no encontrada");
            }
            Sede sede = sedeOpt.get();

            vincularProyectoASede(p1, sede);
            vincularProyectoASede(p2, sede);

            Optional<Empleado> empOpt = empleadoRepo.findById("12345678A");
            if (empOpt.isPresent()) {
                Empleado emp = empOpt.get();
                DatosProfesionales dp = new DatosProfesionales(emp, "A1", 45000.0);
                datosProfRepo.save(dp);
            }

        } catch (DataIntegrityViolationException e) {
            System.out.println(ROJO + " ANGEL --> Data Integrity violation: no se puede duplicar valores " + RESET);
        } catch (Exception e) {
            System.out.println(ROJO + " ERROR: " + e.getMessage() + RESET);
        }
    }

    private void vincularProyectoASede(Proyecto p, Sede s) {
        ProyectoSedeId id = new ProyectoSedeId(p.getIdProy(), s.getIdSede());
        ProyectoSede ps = new ProyectoSede(id, s, p, new Date(System.currentTimeMillis()));
        proyectoSedeRepo.save(ps);
    }

    @Transactional(readOnly=true)
    public void verificarDatosCreados() {
        List<Proyecto> proyectos = proyectoRepo.findAll();
        for (Proyecto p : proyectos) {
            System.out.println(VERDE + "\nPROYECTO: " + p.getNomProy() +
                    "\nID: " + p.getIdProy() +
                    "\nFECHA INICIO: " + p.getFInicio() + RESET);
        }

        List<ProyectoSede> vinculos = proyectoSedeRepo.findAll();
        for (ProyectoSede ps : vinculos) {
            System.out.println(VERDE + "\nVÍNCULO PROYECTO-SEDE:" +
                    "\nPROYECTO: " + ps.getProyecto().getNomProy() +
                    "\nSEDE: " + ps.getSede().getNomSede() +
                    "\nFECHA VÍNCULO: " + ps.getFInicio() + RESET);
        }

        List<DatosProfesionales> datosProfs = datosProfRepo.findAll();
        for (DatosProfesionales dp : datosProfs) {
            System.out.println(VERDE + "\nDATOS PROFESIONALES:" +
                    "\nEMPLEADO: " + dp.getEmpleado().getNomEmp() +
                    "\nCATEGORÍA: " + dp.getCategoria() +
                    "\nSUELDO: " + dp.getSueldoBrutoAnual() + "€" + RESET);
        }

        List<Departamento> departamentos = departamentoRepo.findAll();
        for (Departamento d : departamentos) {
            System.out.println(VERDE + "\nDEPARTAMENTO: " + d.getNomDepto() +
                    "\nUBICADO EN SEDE: " + d.getSede().getNomSede() + RESET);
        }
    }
}