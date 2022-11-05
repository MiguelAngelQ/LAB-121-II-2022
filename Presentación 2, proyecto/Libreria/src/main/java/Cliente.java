
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Micky
 */
public class Cliente extends Persona{
    private int id_cliente;
    private String fecha_registro;
    
    public Cliente(){
        super();
        id_cliente = 1;
        fecha_registro = "01/03/2019";
    }
    
    public void leer(){
        Scanner in = new Scanner(System.in);
        System.out.println("\tCLIENTE");
        super.leer();
        System.out.println("\tId_cliente: ");
        id_cliente = in.nextInt();in.nextLine();
        System.out.println("\tFecha_registro: ");
        fecha_registro = in.nextLine();
        System.out.println("");
    }
    
    public void mostrar(){
        System.out.println("\tCLIENTE");
        super.mostrar();
        System.out.println("\tIs_cliente: " + id_cliente);
        System.out.println("\tFecha_registro: " + fecha_registro);
        System.out.println("");
    }
    
    public int getId_cliente() {
		return id_cliente;
	}

	public void setId_cliente(int id_cliente) {
		this.id_cliente = id_cliente;
	}

	public String getFecha_registro() {
		return fecha_registro;
	}

	public void setFecha_registro(String fecha_registro) {
		this.fecha_registro = fecha_registro;
	}
}
