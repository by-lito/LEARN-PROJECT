package springboot.ejs.servicios;


import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import springboot.ejs.dominio.Employee;
import springboot.ejs.repositorios.EmployeeRepository;


import java.math.BigDecimal;
import java.util.List;
import java.util.Optional;

@Service
@Transactional
public class EmployeeServiceImpl implements EmployeeService {

    private final EmployeeRepository employeeRepository;

    public EmployeeServiceImpl(EmployeeRepository employeeRepository) {
        this.employeeRepository = employeeRepository;
    }

    @Override
    @Transactional(readOnly = true)
    public List<Employee> consultarTodos() {
        return employeeRepository.findAll();
    }

    @Override
    @Transactional(readOnly = true)
    public Optional<Employee> consultarPorId(Long id) {
        return employeeRepository.findById(id);
    }

    @Override
    public Employee insertar(Employee employee) {
        return employeeRepository.save(employee);
    }

    @Override
    public Employee actualizar(Long id, Employee employeeDetails) {

        Employee employee = employeeRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Empleado no encontrado"));

        employee.setFirstName(employeeDetails.getFirstName());
        employee.setLastName(employeeDetails.getLastName());
        employee.setEmail(employeeDetails.getEmail());
        employee.setPhoneNumber(employeeDetails.getPhoneNumber());
        employee.setHireDate(employeeDetails.getHireDate());
        employee.setSalary(employeeDetails.getSalary());
        employee.setCommissionPct(employeeDetails.getCommissionPct());
        employee.setJob(employeeDetails.getJob());
        employee.setDepartment(employeeDetails.getDepartment());
        employee.setManager(employeeDetails.getManager());

        return employeeRepository.save(employee);
    }

    @Override
    public void borrar(Long id) {
        Employee employee = employeeRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Empleado no encontrado"));

        employeeRepository.delete(employee);
    }

    @Override
    @Transactional(readOnly = true)
    public List<Employee> buscarVip(BigDecimal minSalary) {
        return employeeRepository.findBySalaryGreaterThanEqual(minSalary);
    }

    @Override
    public List<Employee> buscarEmpleadosVip(BigDecimal bigDecimal) {
        return List.of();
    }
}

