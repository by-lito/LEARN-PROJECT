package com.acc.datos.hybernate_project.repositorios;

import com.acc.datos.hybernate_project.pojos.DatosProfesionales;
import org.springframework.data.jpa.repository.JpaRepository;

public interface DatosProfesionalesRepository extends JpaRepository<DatosProfesionales,String> {
}
