/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 29/9/2022
 * Time: 16:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Herencia_LAB_121{
	class Program{
		public static void Main(string[] args){
			CSecundaria a = new CSecundaria();
			CPreparatoria b = new CPreparatoria(2, "Tania Tarquino", "17C", "Santa Cruz de la Sierra", "I/2023", "Ciencias Puras");
			//A
			a.mostrar();
			b.mostrar();
			//B
			b.incisoB(a);
			//C
			string ci = "10052678";
			if(a.existeEstudiante(ci) && a.getCiudad() == "Santa Cruz de la Sierra"){
				Console.WriteLine("Si se encuentra cursando");
			}else if(b.existeEstudiante(ci) && b.getCiudad() == "Santa Cruz de la Sierra"){
				Console.WriteLine("Si se encuentra cursando");
			}else{
				Console.WriteLine("No encuentra cursando");
			}
			
			Console.ReadKey(true);
		}
	}
}