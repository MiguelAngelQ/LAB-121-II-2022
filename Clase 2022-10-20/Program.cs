/*
 * Created by SharpDevelop.
 * User: Kaylen
 * Date: 20/10/2022
 * Time: 16:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Recu
{
	class Program{
		public static void Main(string[] args){
			//a)
			Participante p1 = new Participante();
			Participante p2 = new Participante(2, "Alan Brito");
			Participante p3 = new Participante(3, "Maria Martinez");
			
			Producto pr1 = new Producto();
			Producto pr2 = new Producto("chupete", 0.50);
			Producto pr3 = new Producto("helado", 6.50);
			Producto pr4 = new Producto("queque", 78.50);
			
			Feria f = new Feria(pr1, pr2, pr3, pr4);
			f.agregarParticipante(p1);
			f.agregarParticipante(p2);
			f.agregarParticipante(p3);
			
			f.mostrar();
			
			//b)
			f.realizarCompra("queque");
			f.mostrar();
			
			//c)
			f.inicisoC();
			Console.ReadKey(true);
		}
	}
}