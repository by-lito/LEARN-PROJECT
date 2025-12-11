package com.acc.datos.hybernate_project.util;

import com.acc.datos.hybernate_project.servicios.SetupService55;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

@Component
public class Runner55 implements CommandLineRunner {

    SetupService55 service = new SetupService55();

    public Runner55(SetupService55 setupService) {
        this.service = setupService;
    }

    @Override
    public void run(String... args) throws Exception {

        try {
            service.createStructureAngel();
        }catch (Exception e){
            e.printStackTrace();
        }
    }
}
