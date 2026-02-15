package springboot.ejs.dominio;

import jakarta.persistence.*;
@Entity
@Table(name = "countries")
public class Country {
    @Id
    @Column(name = "country_id", length = 2)
    private String id; // Es CHAR(2) según el diagrama
    @Column(name = "country_name", length = 40)
    private String countryName;
    @ManyToOne // Muchos Países pertenecen a Una Región
    @JoinColumn(name = "region_id") // Clave foránea física
    private Region region;
// TODO: Generar Getters y Setters y toString

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getCountryName() {
        return countryName;
    }

    public void setCountryName(String countryName) {
        this.countryName = countryName;
    }

    public Region getRegion() {
        return region;
    }

    public void setRegion(Region region) {
        this.region = region;
    }

    @Override
    public String toString() {
        return "Country{" +
                "id='" + id + '\'' +
                ", countryName='" + countryName + '\'' +
                ", region=" + region +
                '}';
    }
}
