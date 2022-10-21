/*
 * Created by SharpDevelop.
 * User: Kaylen
 * Date: 20/10/2022
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Recu{
	public class Producto{
		
		private string nombre;
		private double precio;
		
		public Producto(){
			nombre = "Galleta";
			precio = 6.95;
		}
		
		public Producto(string nombre, double precio){
			this.nombre = nombre;
			this.precio = precio;
		}
		
		public void mostrar(){
			Console.WriteLine("\t\tProducto: ");
			Console.WriteLine("\t\tnombre: " + nombre);
			Console.WriteLine("\t\tprecio: " + precio);
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public double getPrecio(){
			return precio;
		}
		
	}
}
