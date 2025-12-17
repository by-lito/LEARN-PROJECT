package com.acc.datos.hybernate_project.repositorios;

import com.acc.datos.hybernate_project.pojos.ProyectoSede;
import com.acc.datos.hybernate_project.pojos.ProyectoSedeId;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProyectoSedeRepository extends JpaRepository<ProyectoSede, ProyectoSedeId> {

}
