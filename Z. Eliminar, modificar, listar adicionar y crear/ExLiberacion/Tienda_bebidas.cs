/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 21:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{
	[Serializable]
	public class Tienda_bebidas : Tienda{
		private int nro_bebidas;
		private Bebida []b = new Bebida[50];
		private string reg_sanitario;
		
		public Tienda_bebidas() : base(){
			nro_bebidas = 1;
			b[0] = new Bebida();
			reg_sanitario = "17fg";
		}
		
		
		public void leer(){
			Console.WriteLine(".......................Tienda de bebidas");
			base.leer();
			Console.WriteLine("Into nro_bebidas: ");
			nro_bebidas = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i < nro_bebidas; i++){
				b[i] = new Bebida();
				b[i].leer();
			}
			Console.WriteLine("Into reg_sanitario: ");
			reg_sanitario = Console.ReadLine();
		}
		
		public void mostrar(){
			Console.WriteLine(".......................Tienda de bebidas");
			base.mostrar();
			Console.WriteLine("\tnro_bebidas: " + nro_bebidas);
			for(int i = 0; i < nro_bebidas; i++)
				b[i].mostrar();
			Console.WriteLine("\treg_sanitario: " + reg_sanitario);
		}
		
		public void mostrar(int precioX){
			//base.mostrar();
			Console.WriteLine("\tnro_bebidas: " + nro_bebidas);
			for(int i = 0; i < nro_bebidas; i++){
				if(b[i].getPrecio() <= precioX)
					b[i].mostrar();
			}
			//Console.WriteLine("\treg_sanitario: " + reg_sanitario);
		}
		
		public void lectorbb(BinaryReader j){
			base.lectort(j);
			this.nro_bebidas = j.ReadInt32();
			this.reg_sanitario = j.ReadString();
			for(int i = 0; i < nro_bebidas; i++)
				b[i].lectorb(j);
			
		}
		
		public void escritorbb(BinaryWriter j){
			base.escritort(j);
			j.Write(this.nro_bebidas);
			j.Write(this.reg_sanitario);
			for(int i = 0; i < nro_bebidas; i++)
				b[i].escritorb(j);
		}
		
		public int getNro_bebidas() {
			return nro_bebidas;
		}
		public void setNro_bebidas(int nro_bebidas) {
			this.nro_bebidas = nro_bebidas;
		}
		public string getReg_sanitario() {
			return reg_sanitario;
		}
		public void setReg_sanitario(string reg_sanitario) {
			this.reg_sanitario = reg_sanitario;
		}
		
	}
}
