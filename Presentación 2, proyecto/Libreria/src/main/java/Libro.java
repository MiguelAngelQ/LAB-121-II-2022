
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Micky
 */
public class Libro {
    private int id_libro, nro_paginas;
    private String nombre, autor, observaciones;
    private boolean disponible;
    
    public Libro(){
        id_libro = 1;
        nombre = "La Iliada";
        autor = "Homero";
        nro_paginas = 752;
        disponible = true;
        observaciones = "";
    }
    
    public void leer(){
        Scanner in = new Scanner(System.in);
        System.out.println("\tLIBRO");
        System.out.println("\tId_libro: ");
        id_libro = in.nextInt(); in.nextLine();
        System.out.println("\tNombre: ");
        nombre = in.nextLine();
        System.out.println("\tAutor: ");
        autor = in.nextLine();
        System.out.println("\tNro_paginas: ");
        nro_paginas = in.nextInt();in.nextLine();
        System.out.println("\tDisponible: ");
        disponible = in.nextBoolean();in.nextLine();
        System.out.println("\tObservaciones: ");
        observaciones = in.next();in.nextLine();
        System.out.println("");
    }
    
    public void mostrar(){
        System.out.println("\tLIBRO");
        System.out.println("\tId_libro: " + id_libro);
        System.out.println("\tNombre: " + nombre);
        System.out.println("\tAutor: " + autor);
        System.out.println("\tNro_paginas: " + nro_paginas);
        System.out.println("\tDisponible: " + disponible);
        System.out.println("\tObservaciones: " + observaciones);
        System.out.println("");
    }
    public int getId_libro() {
		return id_libro;
	}

	public void setId_libro(int id_libro) {
		this.id_libro = id_libro;
	}

	public int getNro_paginas() {
		return nro_paginas;
	}

	public void setNro_paginas(int nro_paginas) {
		this.nro_paginas = nro_paginas;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getAutor() {
		return autor;
	}

	public void setAutor(String autor) {
		this.autor = autor;
	}

	public String getObservaciones() {
		return observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public boolean isDisponible() {
		return disponible;
	}

	public void setDisponible(boolean disponible) {
		this.disponible = disponible;
	}
    
}
