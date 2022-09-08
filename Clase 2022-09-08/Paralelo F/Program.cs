/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 8/9/2022
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefensaParaleloF{
	class Program{
		public static void Main(string[] args){
			//a)
			AplicacionMensajeria a = new AplicacionMensajeria("WhatsApp");
			AplicacionMensajeria b = new AplicacionMensajeria("Telegram", "Yamil", "680862");
			a.mostrar();
			b.mostrar();
			
			//b)
			a.inicisoB();
			
			//c)
			a.incisoC(b);
			Console.ReadKey(true);
		}
	}
}