package springboot.ejs.dominio;

import jakarta.persistence.*;

@Entity
@Table(name = "regions")
public class Region {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "region_id")
    private Long id;

    @Column(name = "region_name", nullable = false, length = 25)
    private String regionName;

    public Region() {}

    public Region(String regionName) {
        this.regionName = regionName;
    }

    // Getters y Setters

    public Long getId() {
        return id;
    }

    public String getRegionName() {
        return regionName;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public void setRegionName(String regionName) {
        this.regionName = regionName;
    }

    @Override
    public String toString() {
        return "Region{id=" + id + ", nombre='" + regionName + "'}";
    }
}

