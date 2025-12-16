package ejercicios;
public class Encapsulador {
    private int idImagen;
    private String titulo;
    private String textoContenido;

    public Encapsulador(int idImagen, String textoTitulo, String textoContenido) {
        this.idImagen = idImagen;
        this.titulo = textoTitulo;
        this.textoContenido = textoContenido;
    }
    public int get_idImagen() {return idImagen;}
    public String get_textotitulo() {return titulo;}
    public String get_textoContenido() {return textoContenido;}
}
