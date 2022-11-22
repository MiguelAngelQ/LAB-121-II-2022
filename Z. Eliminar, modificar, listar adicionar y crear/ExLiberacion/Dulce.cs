/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{
	
	[Serializable]
	public class Dulce{
		private string tipo, nombre, sabor;
		private int precio;
		private double peso;
		
		public Dulce(){
			tipo = "masticable";
			nombre = "chupetin";
			sabor = "manzana";
			precio = 1;
			peso = 0.12;
		}
		
		public Dulce(string tipo, string nombre, string sabor, int precio, double peso){
			this.tipo = tipo;
			this.nombre = nombre;
			this.sabor = sabor;
			this.precio = precio;
			this.peso = peso;
		}
		
		public void leer(){
			Console.WriteLine("...............DULCE");
			Console.WriteLine("Into tipo: ");
			tipo = Console.ReadLine();
			Console.WriteLine("Into nombre: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Into sabor: ");
			sabor = Console.ReadLine();
			Console.WriteLine("Into precio: ");
			precio = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Into peso: ");
			peso = Convert.ToDouble(Console.ReadLine());
		}
		
		public void mostrar(){
			Console.WriteLine("................");
			Console.WriteLine("\ttipo: " + tipo);
			Console.WriteLine("\tnombre: " + nombre);
			Console.WriteLine("\tsabor: " + sabor);
			Console.WriteLine("\tprecio: " + precio);
			Console.WriteLine("\tpeso: " + peso);
		}
		
		public void lectord(BinaryReader j){
			this.tipo = j.ReadString();
			this.nombre = j.ReadString();
			this.sabor = j.ReadString();
			this.precio = j.ReadInt32();
			this.peso = j.ReadDouble();
		}
		
		public void escritord(BinaryWriter j){
			j.Write(this.tipo);
			j.Write(this.nombre);
			j.Write(this.sabor);
			j.Write(this.precio);
			j.Write(this.peso);
		}
		
		public string getTipo() {
			return tipo;
		}
	
		public void setTipo(string tipo) {
			this.tipo = tipo;
		}
	
		public string getNombre() {
			return nombre;
		}
	
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
	
		public string getSabor() {
			return sabor;
		}
	
		public void setSabor(string sabor) {
			this.sabor = sabor;
		}
	
		public int getPrecio() {
			return precio;
		}
	
		public void setPrecio(int precio) {
			this.precio = precio;
		}
	
		public double getPeso() {
			return peso;
		}
	
		public void setPeso(double peso) {
			this.peso = peso;
		}

		
	}
}
