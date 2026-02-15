package springboot.ejs.dominio;
import java.io.Serializable;
import java.time.LocalDate;
import java.util.Objects;
public class JobHistoryId implements Serializable {
    private Long employee; // Debe coincidir con el nombre del atributo en la entidad
    private LocalDate startDate;
    // Constructores, equals() y hashCode() son OBLIGATORIOS aquí
    public JobHistoryId() {}
    public JobHistoryId(Long employee, LocalDate startDate) {
        this.employee = employee;
        this.startDate = startDate;
    }
// TODO: Generar equals() y hashCode() desde el IDE

    public Long getEmployee() {
        return employee;
    }

    public void setEmployee(Long employee) {
        this.employee = employee;
    }

    public LocalDate getStartDate() {
        return startDate;
    }

    public void setStartDate(LocalDate startDate) {
        this.startDate = startDate;
    }

    @Override
    public String toString() {
        return "JobHistoryId{" +
                "employee=" + employee +
                ", startDate=" + startDate +
                '}';
    }
}
