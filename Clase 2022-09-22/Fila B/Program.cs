/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 26/9/2022
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefensaB{
	
	class Program{
		
		public static void Main(string[] args){
			Aerolinea a = new Aerolinea();
			Aerolinea b = new Aerolinea(true);
			a.mostrar();
			b.mostrar();
			
			//Inciso A
			a.incrementar(2);
			a.mostrar();
			
			//Inciso B
			a.incrementar(150, "copiloto");
			a.mostrar();
			
			//Inciso C
			a = a + b;
			a.mostrar();
			
			Console.ReadKey(true);
		}
	}
}