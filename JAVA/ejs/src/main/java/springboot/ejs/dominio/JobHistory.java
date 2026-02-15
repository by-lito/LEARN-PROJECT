package springboot.ejs.dominio;

import jakarta.persistence.*;
import java.time.LocalDate;
@Entity
@Table(name = "job_history")
@IdClass(JobHistoryId.class) // Vinculamos la clase de la clave compuesta
public class JobHistory {
    @Id
    @ManyToOne // Parte de la PK y además es FK
    @JoinColumn(name = "employee_id")
    private Employee employee;
    @Id
    @Column(name = "start_date")
    private LocalDate startDate;
    @Column(name = "end_date", nullable = false)
    private LocalDate endDate;
    @ManyToOne
    @JoinColumn(name = "job_id", nullable = false)
    private Job job;
    @ManyToOne
    @JoinColumn(name = "department_id")
    private Department department;
// TODO: Generar Getters y Setters

    public Employee getEmployee() {
        return employee;
    }

    public void setEmployee(Employee employee) {
        this.employee = employee;
    }

    public LocalDate getStartDate() {
        return startDate;
    }

    public void setStartDate(LocalDate startDate) {
        this.startDate = startDate;
    }

    public LocalDate getEndDate() {
        return endDate;
    }

    public void setEndDate(LocalDate endDate) {
        this.endDate = endDate;
    }

    public Job getJob() {
        return job;
    }

    public void setJob(Job job) {
        this.job = job;
    }

    public Department getDepartment() {
        return department;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }

    @Override
    public String toString() {
        return "JobHistory{" +
                "employee=" + employee +
                ", startDate=" + startDate +
                ", endDate=" + endDate +
                ", job=" + job +
                ", department=" + department +
                '}';
    }
}
