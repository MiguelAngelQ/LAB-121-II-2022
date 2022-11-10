
import java.io.Serializable;
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Micky
 */
public class Empleado extends Persona implements Serializable{
    private int id_empleado;
    private String cargo, fecha_ingreso;
    private double sueldo;
    
    public Empleado(){
        super();
        id_empleado = 1;
        cargo = "Bibliotecario";
        sueldo = 3600.99;
        fecha_ingreso = "12/12/2021";//dd/mm/aaaa 
    }
    
    public void leer(){
        Scanner in = new Scanner(System.in);
        System.out.println("EMPLEADO");
        super.leer();
        System.out.println("Id_empleado: ");
        id_empleado = in.nextInt(); in.nextLine();
        System.out.println("Cargo: ");
        cargo = in.nextLine();
        System.out.println("Sueldo: ");
        sueldo = in.nextDouble(); in.nextLine();
        System.out.println("Fecha_ingreso: ");
        fecha_ingreso = in.nextLine();
        System.out.println("");
    }
    
    public void mostrar(){
        System.out.println("\tEMPLEADO");
        super.mostrar();
        System.out.println("\tId_empleado: " + id_empleado);
        System.out.println("\tCargo: " + cargo);
        System.out.println("\tSueldo: " + sueldo);
        System.out.println("\tFecha_ingreso: " + fecha_ingreso);
        System.out.println("");
    }
    public int getId_empleado() {
		return id_empleado;
	}

	public void setId_empleado(int id_empleado) {
		this.id_empleado = id_empleado;
	}

	public String getCargo() {
		return cargo;
	}

	public void setCargo(String cargo) {
		this.cargo = cargo;
	}

	public String getFecha_ingreso() {
		return fecha_ingreso;
	}

	public void setFecha_ingreso(String fecha_ingreso) {
		this.fecha_ingreso = fecha_ingreso;
	}

	public double getSueldo() {
		return sueldo;
	}

	public void setSueldo(double sueldo) {
		this.sueldo = sueldo;
	}
}
