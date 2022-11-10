
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
public class Prestamo implements Serializable{
       private int id_prestamo, id_cliente, id_libro;
       private String fecha_prestamo, observaciones, estado;
       
       public Prestamo(){
           id_prestamo = 1;
           fecha_prestamo = "04/11/2022";
           id_cliente = 1;
           id_libro = 1;
           observaciones = "";
           estado = "devuelto";
       }
       
       public void leer(){
            Scanner in = new Scanner(System.in);
            System.out.println("PRESTAMO");
            System.out.println("Id_prestamo: ");
            id_prestamo = in.nextInt(); in.nextLine();
            System.out.println("Fecha_prestamo: ");
            fecha_prestamo = in.nextLine();
            System.out.println("Id_cliente: ");
            id_cliente = in.nextInt(); in.nextLine();
            System.out.println("Id_libro: ");
            id_libro = in.nextInt(); in.nextLine();
            System.out.println("Observaciones: ");
            observaciones = in.nextLine();
            estado = "Prestado";
        
       }
       public void mostrar(){
           System.out.println("\tPRESTAMO");
           System.out.println("\tId_prestamo: " + id_prestamo);
           System.out.println("\tFecha_prestamo: " + fecha_prestamo);
           System.out.println("\tId_cliente: " + id_cliente);
           System.out.println("\tId_libro: " + id_libro);
           System.out.println("\tObservaciones: " + observaciones);
           System.out.println("\tEstado: " + estado);
       }
       public int getId_prestamo() {
		return id_prestamo;
	}

	public void setId_prestamo(int id_prestamo) {
		this.id_prestamo = id_prestamo;
	}

	public int getId_cliente() {
		return id_cliente;
	}

	public void setId_cliente(int id_cliente) {
		this.id_cliente = id_cliente;
	}

	public int getId_libro() {
		return id_libro;
	}

	public void setId_libro(int id_libro) {
		this.id_libro = id_libro;
	}

	public String getFecha_prestamo() {
		return fecha_prestamo;
	}

	public void setFecha_prestamo(String fecha_prestamo) {
		this.fecha_prestamo = fecha_prestamo;
	}

	public String getObservaciones() {
		return observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public String getEstado() {
		return estado;
	}

	public void setEstado(String estado) {
		this.estado = estado;
	}
}
