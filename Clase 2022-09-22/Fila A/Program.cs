/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 26/9/2022
 * Time: 11:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefensaA{
	class Program{
		public static void Main(string[] args){
			Clinica a = new Clinica();
			Paciente b = new Paciente();
			a.mostrar();
			b.mostrar();
			
			//Inciso A
			a.resolver("Dr. Santamaria");
			
			//Inciso B
			a.resolver(b);
			
			//Inciso C
			a = a % "Reservado";
			
			Console.ReadKey(true);
		}
	}
}