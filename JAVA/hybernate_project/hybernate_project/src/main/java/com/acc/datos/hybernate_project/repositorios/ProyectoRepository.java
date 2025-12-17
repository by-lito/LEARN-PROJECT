package com.acc.datos.hybernate_project.repositorios;

import com.acc.datos.hybernate_project.pojos.Proyecto;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProyectoRepository extends JpaRepository<Proyecto,Integer> {

}
