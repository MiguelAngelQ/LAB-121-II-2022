/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 2/9/2022
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SolucionPrimerParcial.I2022{
	class Program{
		public static void Main(string[] args){
			Flota a = new Flota();
			Flota b = new Flota("ACX788", 49);
			a.mostrar();
			b.mostrar();
			
			//Inciso A
			b.incisoA("Masculino");
			
			//Inciso B
			a.incisoB(b);
			
			//Inciso C
			if(a.incisoC()){
				Console.WriteLine("Alexis sera feliz");
			}else{
				Console.WriteLine("Alexis no sera feliz");
			}
			
			Console.ReadKey(true);
		}
	}
}