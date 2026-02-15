package springboot.ejs.dominio;
import jakarta.persistence.*;
@Entity
@Table(name = "departments")
public class Department {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "department_id")
    private Long id;
    @Column(name = "department_name", nullable = false, length = 30)
    private String departmentName;
    @ManyToOne
    @JoinColumn(name = "location_id")
    private Location location;
    // Nota: El diagrama tiene MANAGER_ID, que sería un Empleado.
// Para evitar referencias circulares complejas al inicio, lo mapeamos simple o lo omitimos por ahora.
    @Column(name = "manager_id")
    private Long managerId;
// TODO: Generar Getters y Setters

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getDepartmentName() {
        return departmentName;
    }

    public void setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
    }

    public Location getLocation() {
        return location;
    }

    public void setLocation(Location location) {
        this.location = location;
    }

    public Long getManagerId() {
        return managerId;
    }

    public void setManagerId(Long managerId) {
        this.managerId = managerId;
    }

    @Override
    public String toString() {
        return "Department{" +
                "id=" + id +
                ", departmentName='" + departmentName + '\'' +
                ", location=" + location +
                ", managerId=" + managerId +
                '}';
    }
}
