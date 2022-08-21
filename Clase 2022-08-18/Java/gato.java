package claseuno;

import java.util.Scanner;

public class gato {
	// atributos o caracteristicas
	private String nombre;
	private int edad;
	private String color;
	private String tamaño;// grande, mediano, pequeño
	private String raza;

	// constructor por defecto
	public gato() {
		nombre = "Panquesito";
		edad = 1;
		color = "blanco";
		tamaño = "mediano";
		raza = "angora";
	}

	// constructor por parametros
	public gato(String n, int e, String c, String t, String raza) {
		nombre = n;
		edad = e;
		color = c;
		tamaño = t;
		this.raza = raza;
	}

	// metodo leer
	public void leer() {
		Scanner in = new Scanner(System.in);// esto es para leer datos
		System.out.print("Introduzca nombre: ");
		nombre = in.next();// leer un string
		System.out.print("Introduzca edad: ");
		edad = in.nextInt();// leer un int
		System.out.print("Introduzca color: ");
		color = in.next();
		System.out.print("Introduzca tamaño: ");
		tamaño = in.next();
		System.out.print("Introduzca raza: ");
		raza = in.next();
	}

	public void mostrar() {
		System.out.println(nombre + ", " + edad + ", " + color + ", " + tamaño + ", " + raza);
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public int getEdad() {
		return edad;
	}

	public void setEdad(int edad) {
		this.edad = edad;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getTamaño() {
		return tamaño;
	}

	public void setTamaño(String tamaño) {
		this.tamaño = tamaño;
	}

	public String getRaza() {
		return raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

}
