/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{
	
	[Serializable]
	public class Tienda_dulces : Tienda{
		private int nro_dulces;
		private Dulce []d = new Dulce[50];
		private string marca;
		
		public Tienda_dulces() : base(){
			nro_dulces = 2;
			d[0] = new Dulce();
			d[1] = new Dulce("relleno", "chocolatin", "chocolate", 2, 1.85);
			marca = "arcor";
		}
		
		public Tienda_dulces(int NIT, string nombre, string direccion, string marca) : base(NIT, nombre, direccion){
			marca = marca;
			nro_dulces = 1;
			d[0] = new Dulce("mezclado", "vainillin", "vainilla", 3, 1.95);
			marca = "delizia";
		}
		
		public void leer(){
			Console.WriteLine(".......................Tienda de dulces");
			base.leer();
			Console.WriteLine("Into nro_dulces: ");
			nro_dulces = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i < nro_dulces; i++){
				d[i] = new Dulce();
				d[i].leer();
			}
			Console.WriteLine("Into marca: ");
			marca = Console.ReadLine();
		}
		
		public void mostrar(){
			Console.WriteLine(".......................Tienda de dulces");
			base.mostrar();
			Console.WriteLine("\tnro_dulces: " + nro_dulces);
			for(int i = 0; i < nro_dulces; i++)
				d[i].mostrar();
			Console.WriteLine("\tmarca: " + marca);
		}
		
		public void lector(BinaryReader j){
			base.lectort(j);
			this.nro_dulces = j.ReadInt32();
			this.marca = j.ReadString();
			for(int i = 0; i < nro_dulces; i++)
				d[i].lectord(j);
			
		}
		
		public void escritor(BinaryWriter j){
			base.escritort(j);
			j.Write(this.nro_dulces);
			j.Write(this.marca);
			for(int i = 0; i < nro_dulces; i++)
				d[i].escritord(j);
		}
		
		public int getNro_dulces() {
			return nro_dulces;
		}
	
		public void setNro_dulces(int nro_dulces) {
			this.nro_dulces = nro_dulces;
		}
	
		public string getMarca() {
			return marca;
		}
	
		public void setMarca(string marca) {
			this.marca = marca;
		}
		
	}
}
