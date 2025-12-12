package com.acc.datos.hybernate_project.servicios;

import com.acc.datos.hybernate_project.pojos.Departamento;
import com.acc.datos.hybernate_project.pojos.Empleado;
import com.acc.datos.hybernate_project.pojos.Sede;
import com.acc.datos.hybernate_project.repositorios.DepartamentoRepository;
import com.acc.datos.hybernate_project.repositorios.EmpleadoRepository;
import com.acc.datos.hybernate_project.repositorios.SedeRepository;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
@Service
public class VerificarDatos {

    @Autowired
    private EmpleadoRepository empleadoRepository;
    @Autowired
    private SedeRepository sedeRepository;
    @Autowired
    private DepartamentoRepository departamentoRepository;


    public VerificarDatos() {
    }
    @Transactional
    public void verificar() {
        List<Empleado> empleados = empleadoRepository.findAll();
        List<Sede> sedes = sedeRepository.findAll();
        List<Departamento> departamentos = departamentoRepository.findAll();

        for (Empleado e : empleados) {
            System.out.println("\nEMPLEADO: " + e.getNomEmp() +"\nDNI: " + e.getDni() + "\nDEPARTAMENTO: "
            + e.getDepartamento().getNomDepto());
        }
        for (Sede s : sedes) {
            System.out.println("\nSEDE: " + s.getIdSede() + "\nNOMBRE: " + s.getNomSede());
        }
        for (Departamento d : departamentos) {
            System.out.println("\nDEPARTAMENTO: " + d.getIdDepto() + "\nNOMBRE: " + d.getNomDepto() + "\nSEDE: "
                    + d.getSede().getNomSede());
        }
    }

}
