package com.example.listadosymenus.pojos;

public class Videogame {

    String nombre;
    int imagenRes;   // ID de la imagen en drawable
    String url;

    String description;

    public Videogame(String nombre, int imagenRes, String url, String description) {
        this.description = description;
        this.nombre = nombre;
        this.imagenRes = imagenRes;
        this.url = url;
    }

    public String getNombre() {
        return nombre;
    }

    public int getImagenRes() {
        return imagenRes;
    }

    public String getUrl() {
        return url;
    }

    public String getDescription() {
        return description;
    }



}
