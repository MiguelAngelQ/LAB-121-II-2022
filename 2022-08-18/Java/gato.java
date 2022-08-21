package claseuno;

import java.util.Scanner;

public class gato {
	// atributos o caracteristicas
	private String nombre;
	private int edad;
	private String color;
	private String tama�o;// grande, mediano, peque�o
	private String raza;

	// constructor por defecto
	public gato() {
		nombre = "Panquesito";
		edad = 1;
		color = "blanco";
		tama�o = "mediano";
		raza = "angora";
	}

	// constructor por parametros
	public gato(String n, int e, String c, String t, String raza) {
		nombre = n;
		edad = e;
		color = c;
		tama�o = t;
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
		System.out.print("Introduzca tama�o: ");
		tama�o = in.next();
		System.out.print("Introduzca raza: ");
		raza = in.next();
	}

	public void mostrar() {
		System.out.println(nombre + ", " + edad + ", " + color + ", " + tama�o + ", " + raza);
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

	public String getTama�o() {
		return tama�o;
	}

	public void setTama�o(String tama�o) {
		this.tama�o = tama�o;
	}

	public String getRaza() {
		return raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

}
