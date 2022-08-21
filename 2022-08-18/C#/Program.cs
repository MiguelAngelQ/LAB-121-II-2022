
using System;

namespace Clase1{
	class Program{
		public static void Main(string[] args){
			
			gato a = new gato();//usando constructor por defecto
			a.mostrar();
			
			gato b = new gato("Michi", 5, "naranja", "grande", "mestizo");//constructor por parametros
			b.mostrar();
			
			//por teclado
			gato c = new gato();//si o si se debe instanciar
			c.leer();
			c.mostrar();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}