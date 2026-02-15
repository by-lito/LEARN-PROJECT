package springboot.ejs.dominio;

import jakarta.persistence.*;
import lombok.*;

import java.util.List;

@Entity
@Table(name = "departments")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@ToString
@EqualsAndHashCode(onlyExplicitlyIncluded = true)
public class Department {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "department_id")
    @EqualsAndHashCode.Include
    private Long id;

    @Column(name = "department_name", nullable = false, length = 30)
    private String departmentName;

    @ManyToOne
    @JoinColumn(name = "location_id")
    @ToString.Exclude
    private Location location;

    @Column(name = "manager_id")
    private Long managerId;

    @OneToMany(mappedBy = "department")
    @ToString.Exclude
    private List<Employee> employees;
}
