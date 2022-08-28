/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 28/8/2022
 * Time: 08:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Defensa1I_2022{
	class Program{
		public static void Main(string[] args){
			/*
			 a) Crear un obj RedSocial mediante constructor por defecto y tres objetos usuario de distinta
				manera, posteriormente mostrar datos de los objetos creados
			 */
			RedSocial r = new RedSocial();
			Usuario u1 = new Usuario();
			Usuario u2 = new Usuario("gaelCito", 777222, 2008);
			Usuario u3 = new Usuario("kimy", 2442442);
			
			r.mostrar();
			u1.mostrar();
			u2.mostrar();
			u3.mostrar();
			
			/*
			 b) Mostrar los nombres de usuarios mas nuevos en la red socia
			 */
			r.incisoB();
			
			/*
			 c) Sean los tres objetos usuario, registrarlos en la RedSocial si aún no lo están, sabiendo que la
				RedSocial acepta a usuarios que tengan edad mayor a x (Ejem. 18) y su año de ingreso será 2022
			 */
			r.agregaUsuario(u1);
			r.agregaUsuario(u2);
			r.agregaUsuario(u3);
			
			r.mostrar();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}