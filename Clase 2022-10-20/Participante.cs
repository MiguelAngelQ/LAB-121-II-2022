/*
 * Created by SharpDevelop.
 * User: Kaylen
 * Date: 20/10/2022
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Recu{
	public class Participante{
		
		private int codigo;
		private string nombre;
		
		public Participante(){
			codigo = 1;
			nombre = "Juan Perez";
		}
		
		public Participante(int codi, string nombre){
			codigo = codi;
			this.nombre = nombre;
		}
		
		public void mostrar(){
			Console.WriteLine("\tParticipante: ");
			Console.WriteLine("\tcodigo: " + codigo);
			Console.WriteLine("\tnombre: " + nombre);
		}
		
		public int getCodigo(){
			return codigo;
		}
		
		public string getNombre(){
			return nombre;
		}
	}
}
