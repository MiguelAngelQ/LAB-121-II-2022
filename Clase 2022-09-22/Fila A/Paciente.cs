/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 26/9/2022
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefensaA{
	
	public class Paciente{
		
		private string nom, ci;
		
		public Paciente(){
			nom = "Alan Brito";
			ci = "123456";
		}
		
		public void mostrar(){
			Console.WriteLine("Nombre paciente: " + nom);
			Console.WriteLine("CI paciente: " + ci);
			Console.WriteLine();
		}
		
		public string getNom(){
			return nom;
		}
		
		public string getCI(){
			return ci;
		}
	}
}
