package com.acc.datos.hybernate_project.util;

import com.acc.datos.hybernate_project.servicios.ServiceActividad7;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Component;

//@Component
public class RunnerActividad7 implements CommandLineRunner {

    @Autowired
    private ServiceActividad7 servicio;

    @Override
    public void run(String... args) throws Exception {
        System.out.println("INICIANDO ------------------------------------------------------------------------------------------------------------------------");

        servicio.ejecutar();
        servicio.verificarDatosCreados();

        System.out.println("FIN -------------------------------------------------------------------------------------------------------------------------------");
    }
}
