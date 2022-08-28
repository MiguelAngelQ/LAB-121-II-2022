/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 28/8/2022
 * Time: 08:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Defensa1I_2022{
	public class Usuario{
		private string nom;
		private int nroFono;
		private int anioNac;
		
		public Usuario(){
			nom = "soilaBaca";
			nroFono = 7055555;
			anioNac = 1987;
		}
		
		public Usuario(string nom, int nroFono, int anioNac){
			this.nom = nom;
			this.nroFono = nroFono;
			this.anioNac = anioNac;
		}
		
		public Usuario(string nom, int nroFono){
			this.nom = nom;
			this.nroFono = nroFono;
			this.anioNac = 2003;
		}
		
		public void mostrar(){
			Console.WriteLine("nombre: " + nom);
			Console.WriteLine("nroFono: " + nroFono);
			Console.WriteLine("anioNac: " + anioNac);
			Console.WriteLine();
		}
		public string getNom() {
			return nom;
		}
		public void setNom(string nom) {
			this.nom = nom;
		}
		public int getNroFono() {
			return nroFono;
		}
		public void setNroFono(int nroFono) {
			this.nroFono = nroFono;
		}
		public int getAnioNac() {
			return anioNac;
		}
		public void setAnioNac(int anioNac) {
			this.anioNac = anioNac;
		}
	}
}
