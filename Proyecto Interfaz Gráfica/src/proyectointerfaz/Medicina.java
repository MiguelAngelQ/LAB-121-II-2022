package proyectointerfaz;

import java.io.Serializable;

public class Medicina implements Serializable{
    private String codM, nombre;
    private double precio;
    public Medicina()
    {

    }
    public Medicina(String codM, String nombre, double precio) {
        this.codM = codM;
        this.nombre = nombre;
        this.precio = precio;
    }


    public void mostrar() {
        System.out.println("Medicina [codM=" + codM + ", nombre=" + nombre + ", precio=" + precio + "]");
    }


    public String getCodM() {
            return codM;
    }
    public void setCodM(String codM) {
            this.codM = codM;
    }
    public String getNombre() {
            return nombre;
    }
    public void setNombre(String nombre) {
            this.nombre = nombre;
    }
    public double getPrecio() {
            return precio;
    }
    public void setPrecio(double precio) {
            this.precio = precio;
    }
	
}
