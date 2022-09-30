/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 29/9/2022
 * Time: 17:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Herencia_LAB_121{
	
	public class CSecundaria : Curso{//herencia -> claseHija : ClasePadre
		private char paralelo;
		private string nomMateria;
		
		public CSecundaria() : base(){//base() llama al constructor de nuestro padre
			paralelo = 'A';
			nomMateria = "Matematica";
		}
		
		public CSecundaria(int id, String nomDirector, String nroDistrito, String ciudad, char paralelo, 
		                   String nomMateria) : base(id, nomDirector, nroDistrito, ciudad){
			this.paralelo = paralelo;
			this.nomMateria = nomMateria;
		}
		
		public void mostrar(){
			base.mostrar();
			Console.WriteLine("paralelo: " + paralelo);
			Console.WriteLine("nomMateria: " + nomMateria);
			Console.WriteLine();
		}
		
		public char getParalelo() {
			return paralelo;
		}
	
		public void setParalelo(char paralelo) {
			this.paralelo = paralelo;
		}
	
		public String getNomMateria() {
			return nomMateria;
		}
	
		public void setNomMateria(String nomMateria) {
			this.nomMateria = nomMateria;
		}
		
	}
}
