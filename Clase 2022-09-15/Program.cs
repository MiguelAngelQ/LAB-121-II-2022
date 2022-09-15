/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 15/9/2022
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Defensa2{
	class Program{
		public static void Main(string[] args){
			Viaje a = new Viaje();
			Viaje b = new Viaje("Santa Cruz", "24-09-2022", "1234acv");
			AgenciaViaje c = new AgenciaViaje();
			a.mostrar();
			b.mostrar();
			c.mostrar();
			//a
			a = !a;
			//b
			Console.Write("Into genero: ");
			string generoX = Console.ReadLine();
			if((a % generoX) > (b % generoX)){
				a = a / generoX;
			}else{
				b = b / generoX;
			}
			//c
			Console.Write("Into tipoBus: ");
			string tipoX = Console.ReadLine();
			c.mostrar(tipoX);
			c.mostrar();
			Console.ReadKey(true);
		}
	}
}