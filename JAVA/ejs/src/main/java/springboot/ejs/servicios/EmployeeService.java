package springboot.ejs.servicios;

import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import springboot.ejs.dominio.Employee;
import springboot.ejs.repositorios.EmployeeRepository;

import java.math.BigDecimal;
import java.util.List;
import java.util.Optional;
/**
 * Servicio de Negocio para la gestión de Empleados.
 *
 * @Service: Indica a Spring que esta clase es un componente de Lógica de Negocio.
 * Spring la instanciará (Singleton) y la tendremos disponible para inyectar en otros lados.
 */
@Service
public class EmployeeService {
    private final EmployeeRepository employeeRepository;

    // INYECCIÓN POR CONSTRUCTOR
// Es la mejor práctica. Al declarar el repositorio como 'final', aseguramos
// que el servicio no funcione si no se le proporciona un repositorio válido.
    public EmployeeService(EmployeeRepository employeeRepository) {
        this.employeeRepository = employeeRepository;
    }
// ========================================================================
// SECCIÓN 1: SERVICIO CRUD (Create, Read, Update, Delete)
// ========================================================================

    /**
     * Inserta un nuevo empleado en la base de datos.
     *
     * @Transactional: Fundamental. Si ocurre cualquier error dentro de este método
     * (Runtime Exception), Spring hará un ROLLBACK automático, deshaciendo cualquier
     * cambio en la BD para mantener la integridad.
     */
    @Transactional
    public Employee insertar(Employee empleado) {
// Aquí podríamos poner reglas de negocio.
// Ej: Validar que el salario no sea negativo antes de guardar.
        if (empleado.getSalary() != null && empleado.getSalary().doubleValue() < 0) {
            throw new RuntimeException("El salario no puede ser negativo");
        }
        return employeeRepository.save(empleado);
    }

    /**
     * Consulta todos los empleados.
     * readOnly = true: Optimiza la transacción indicando a la BD que solo vamos a leer.
     * Esto hace las consultas más rápidas y consume menos recursos.
     */
    @Transactional(readOnly = true)
    public List<Employee> consultarTodos() {
        return employeeRepository.findAll();
    }

    /**
     * Busca un empleado por su ID.
     */
    @Transactional(readOnly = true)
    public Optional<Employee> consultarPorId(Long id) {
        return employeeRepository.findById(id);
    }

    /**
     * Actualiza un empleado existente.
     * Contiene lógica de negocio: Verificar si existe antes de editar.
     */
    @Transactional
    public Employee actualizar(Long id, Employee empleadoDetalles) {
        Employee empleadoExistente = employeeRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Empleado no encontrado con ID: " + id));
// Actualizamos solo los datos permitidos
        empleadoExistente.setFirstName(empleadoDetalles.getFirstName());
        empleadoExistente.setLastName(empleadoDetalles.getLastName());
        empleadoExistente.setEmail(empleadoDetalles.getEmail());
        empleadoExistente.setSalary(empleadoDetalles.getSalary());
// Al usar @Transactional, el .save() a veces es opcional porque Hibernate
// detecta cambios en el objeto "Managed", pero es buena práctica ponerlo explícito.
        return employeeRepository.save(empleadoExistente);
    }

    /**
     * Borra un empleado por ID.
     */
    @Transactional
    public void borrar(Long id) {
        if (!employeeRepository.existsById(id)) {
            throw new RuntimeException("No se puede borrar: Empleado no encontrado");
        }
        employeeRepository.deleteById(id);
    }
// ========================================================================
// SECCIÓN 2: SERVICIO DE CONSULTA (Reglas de Negocio Específicas)
// ========================================================================

    /**
     * Lógica de negocio para encontrar empleados con altos ingresos ("VIPs").
     * Usa el Query Method personalizado que creamos en el Paso 4.
     */
    @Transactional(readOnly = true)
    public List<Employee> buscarEmpleadosVip(BigDecimal salarioMinimo) {
// Podríamos añadir lógica extra aquí (ej. logging, auditoría)
        System.out.println("LOG DE NEGOCIO: Buscando empleados que ganan más de " + salarioMinimo);
        return employeeRepository.findBySalaryGreaterThan(salarioMinimo);
    }
}
