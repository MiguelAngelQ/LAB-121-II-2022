/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 27/5/2022
 * Time: 18:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Persistencia100{
	[Serializable]
	public class Pasajero{
		private string nombre, asiento;
		private int edad;
		public Pasajero(){
			nombre = "Juan Perez";
			edad = 51;
			asiento = "A2";
		}
		public Pasajero(string n, int e, string a){
			nombre = n;
			edad = e;
			asiento = a;
		}		
		public void leer(){
			Console.WriteLine("Introduzca nombre: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Introduzca edad: ");
			edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Introduzca asiento: ");
			asiento = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("\t" + nombre + ", " + edad + ", " + asiento);
		}
		public void escribir(BinaryWriter escritor){
            escritor.Write(this.nombre);
            escritor.Write(this.edad);
            escritor.Write(this.asiento);
        }
        public void lectura( BinaryReader lector) {
            this.nombre = lector.ReadString();
            this.edad = lector.ReadInt32();
            this.asiento = lector.ReadString();
        }
		  public string getNombre() {
			return nombre;
		}
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
		public string getAsiento() {
			return asiento;
		}
		public void setAsiento(string asiento) {
			this.asiento = asiento;
		}
		public int getEdad() {
			return edad;
		}
		public void setEdad(int edad) {
			this.edad = edad;
		}
	}
}
