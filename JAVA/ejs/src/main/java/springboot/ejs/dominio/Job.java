package springboot.ejs.dominio;
import jakarta.persistence.*;
@Entity
@Table(name = "jobs")
public class Job {
    @Id
    @Column(name = "job_id", length = 10)
    private String id; // Ejemplo: 'IT_PROG'
    @Column(name = "job_title", nullable = false, length = 35)
    private String jobTitle;
    private Double minSalary;
    private Double maxSalary;
// TODO: Generar Getters y Setters y toString

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getJobTitle() {
        return jobTitle;
    }

    public void setJobTitle(String jobTitle) {
        this.jobTitle = jobTitle;
    }

    public Double getMinSalary() {
        return minSalary;
    }

    public void setMinSalary(Double minSalary) {
        this.minSalary = minSalary;
    }

    public Double getMaxSalary() {
        return maxSalary;
    }

    public void setMaxSalary(Double maxSalary) {
        this.maxSalary = maxSalary;
    }

    @Override
    public String toString() {
        return "Job{" +
                "id='" + id + '\'' +
                ", jobTitle='" + jobTitle + '\'' +
                ", minSalary=" + minSalary +
                ", maxSalary=" + maxSalary +
                '}';
    }
}
