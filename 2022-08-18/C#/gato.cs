
using System;

namespace Clase1{
	
	public class gato{
		//atributos o caracteristicas
		private string nombre;
		private int edad;
		private string color;
		private string tamaño;//grande, mediano, pequeño
		private string raza;
		
		//constructor por defecto
		public gato(){
			nombre = "Panquesito";
			edad = 1;
			color = "blanco";
			tamaño = "mediano";
			raza = "angora";
		}
		
		//constructor por parametros
		public gato(string n, int e, string c, string t, string raza){
			nombre = n;
			edad = e;
			color = c;
			tamaño = t;
			this.raza = raza;
		}
		
		//metodo leer
		public void leer(){
			Console.Write("Introduzca nombre: ");
			nombre = Console.ReadLine();//leer un string
			Console.Write("Introduzca edad: ");
			edad = int.Parse(Console.ReadLine());//leer un int
			Console.Write("Introduzca color: ");
			color = Console.ReadLine();
			Console.Write("Introduzca tamaño: ");
			tamaño = Console.ReadLine();
			Console.Write("Introduzca raza: ");
			raza = Console.ReadLine();
		}

		
		//metodo mostrar
		public void mostrar(){
			Console.WriteLine(nombre + ", " + edad + ", " + color + ", " + tamaño + ", " + raza);
		}
		
		//getters: obtener
		//nombre
		public String getNombre() {
				return nombre;
			}

			public void setNombre(string nombre) {
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
}
