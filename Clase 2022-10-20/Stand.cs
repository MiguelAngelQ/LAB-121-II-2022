/*
 * Created by SharpDevelop.
 * User: Kaylen
 * Date: 20/10/2022
 * Time: 16:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Recu{
	public class Stand{
		
		private string tamanio;
		private int codParticipante, nroProductos;
		private Producto[] p = new Producto[30];
		
		public Stand(){
			tamanio = "mediano";
			codParticipante = 1;
			nroProductos = 0;//en cero porque es agregacion
		}
		
		public Stand(string tamanio, int codParticipante){
			this.tamanio = tamanio;
			this.codParticipante = codParticipante;
			nroProductos = 0;
		}
		
		public void agregarProducto(Producto x){
			p[nroProductos] = new Producto();
			p[nroProductos] = x;
			nroProductos += 1;
		}
		
		public void mostrar(){
			Console.WriteLine("\tStand: ");
			Console.WriteLine("\ttamanio: " + tamanio);
			Console.WriteLine("\tcodParticipante: " + codParticipante);
			Console.WriteLine("\tnroProductos: " + nroProductos);
			for(int i = 0; i < nroProductos; i++){
				p[i].mostrar();
			}
		}
		
		public double montoTotal(){
			double ans = 0.0;
			for(int i = 0; i < nroProductos; i++){
				ans += p[i].getPrecio();
			}
			return ans;
		}
		
		public int getNroProductos(){
			return nroProductos;
		}
		
		public bool comprar(string nomProd){
			for(int i = 0; i < nroProductos; i++){
				if(p[i].getNombre() == nomProd){
					for(int j = i; j < nroProductos - 1; j++){
						p[j] = p[j + 1];
					}
					nroProductos -= 1;
					Console.WriteLine("Compra exitosa!!!");
					return true;
				}
			}
			return false;
		}
		
		public int getCodParticipante(){
			return codParticipante;
		}
	}
}
