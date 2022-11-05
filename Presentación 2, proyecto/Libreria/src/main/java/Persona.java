
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Micky
 */
public class Persona {
    protected int ci;
    protected String nombre, paterno, materno;
    
    public Persona(){
        ci = 9978563;
        nombre = "Juan";
        paterno = "Perez";
        materno = "Perez";
    }
    
    public void leer(){
        Scanner in = new Scanner(System.in);
        System.out.println("\tCI:");
        ci = in.nextInt(); in.nextLine();
        System.out.println("\tNombre:");
        nombre = in.nextLine();
        System.out.println("\tPaterno:");
        paterno = in.nextLine();
        System.out.println("\tMaterno:");
        materno = in.nextLine();
    }
    
    public void mostrar(){
        System.out.println("\tCI: " + ci + "\n\tNombre: " + nombre + "\n\tPaterno: " + paterno + "\n\tMaterno: " + materno);
    }
    
    public int getCi() {
		return ci;
	}
	public void setCi(int ci) {
		this.ci = ci;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public String getPaterno() {
		return paterno;
	}
	public void setPaterno(String paterno) {
		this.paterno = paterno;
	}
	public String getMaterno() {
		return materno;
	}
	public void setMaterno(String materno) {
		this.materno = materno;
	}
}
