/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{
	
	[Serializable]
	public class Tienda{
		protected int NIT;
		protected string nombre, direccion;
		
		public Tienda(){
			NIT = 120;
			nombre = "Las brisas";
			direccion = "Av. Arce, esq 4";
		}
		
		public Tienda(int NIT, string nombre, string direccion){
			NIT = NIT;
			nombre = nombre;
			direccion = direccion;
		}
		
		public void leer(){
			Console.WriteLine("Into NIT: ");
			NIT = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Into nombre: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Into direccion: ");
			direccion = Console.ReadLine();
		}
		
		public void mostrar(){
			Console.WriteLine("\tNIT: " + NIT);
			Console.WriteLine("\tnombre: " + nombre);
			Console.WriteLine("\tdireccion: " + direccion);
		}
		
		public void lectort(BinaryReader j){
			this.NIT = j.ReadInt32();
			this.nombre = j.ReadString();
			this.direccion = j.ReadString();
		}
		
		public void escritort(BinaryWriter j){
			j.Write(this.NIT);
			j.Write(this.nombre);
			j.Write(this.direccion);
		}
		
		public int getNIT() {
			return NIT;
		}
	
		public void setNIT(int nIT) {
			NIT = nIT;
		}
	
		public string getNombre() {
			return nombre;
		}
	
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
	
		public string getDireccion() {
			return direccion;
		}
	
		public void setDireccion(string direccion) {
			this.direccion = direccion;
		}
	}
}
