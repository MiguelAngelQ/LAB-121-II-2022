/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{
	[Serializable]
	
	public class Bebida{
		
		private string marca, nombre;
		private int precio, litros;
		
		public Bebida(){
			marca = "coca cola";
			nombre = "fanta";
			precio = 10;
			litros = 2;
		}
		
		public void leer(){
			Console.WriteLine("..............bebida");
			Console.WriteLine("Into marca: ");
			marca = Console.ReadLine();
			Console.WriteLine("Into nombre: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Into precio");
			precio = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Into litros");
			litros = Convert.ToInt32(Console.ReadLine());
		}
		
		public void mostrar(){
			Console.WriteLine("marca: " + marca);
			Console.WriteLine("nombre: " + nombre);
			Console.WriteLine("precio: " + precio);
			Console.WriteLine("litros: " + litros);
		}
		
		public void lectorb(BinaryReader j){
			this.marca = j.ReadString();
			this.nombre = j.ReadString();
			this.precio = j.ReadInt32();
			this.litros = j.ReadInt32();
		}
		
		public void escritorb(BinaryWriter j){
			j.Write(this.marca);
			j.Write(this.nombre);
			j.Write(this.precio);
			j.Write(this.litros);
		}
		
		public string getMarca() {
			return marca;
		}
		public void setMarca(string marca) {
			this.marca = marca;
		}
		public string getNombre() {
			return nombre;
		}
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
		public int getPrecio() {
			return precio;
		}
		public void setPrecio(int precio) {
			this.precio = precio;
		}
		public int getLitros() {
			return litros;
		}
		public void setLitros(int litros) {
			this.litros = litros;
		}
	}
}
