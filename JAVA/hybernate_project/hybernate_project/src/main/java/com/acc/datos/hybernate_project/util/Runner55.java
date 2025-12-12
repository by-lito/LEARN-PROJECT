package com.acc.datos.hybernate_project.util;

import com.acc.datos.hybernate_project.servicios.SetupService55;
import com.acc.datos.hybernate_project.servicios.VerificarDatos;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

@Component
public class Runner55 implements CommandLineRunner {

    SetupService55 service = new SetupService55();
    VerificarDatos verificar = new VerificarDatos();

    public Runner55(SetupService55 setupService,  VerificarDatos verificar) {
        this.service = setupService;
        this.verificar = verificar;
    }

    @Override
    public void run(String... args) throws Exception {

        try {
            service.createStructureAngel();
            verificar.verificar();
        }catch (Exception e){
            e.printStackTrace();
        }
    }
}
