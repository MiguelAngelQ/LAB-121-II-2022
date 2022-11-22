/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ExLiberacion{
	class Program{
		public static void Main(string[] args){
			ArchTiendaDulces af = new ArchTiendaDulces("dulcestienda.dat");
			ArchTiendaBebidas ag = new ArchTiendaBebidas("bebidastienda.dat");
			int op;
			do{
				Console.WriteLine("\nARCHIVO TIENDA DULCES Y BEBIDAS");
				Console.WriteLine("1. Crear ambos\n" +
				                  "2. Adicionar Tienda dulces\n" +
				                  "3. Adicionar Tienda bebidas\n" +
				                  "4. Listar  Tienda dulces\n" +
				                  "5. Listar  Tienda bebidas\n" +
				                  "6. Inciso B\n" +
				                  "7. modificar el nombre de la tienda dulces con nit x\n" +
				                   "8. eliminar la tienda de dulces con nombre x\n" +
				                  "9. Salir\n");
				op = int.Parse(Console.ReadLine());
				switch(op){
					case 1:	
						af.crear();
						ag.crear();
						break;
					case 2: 
						af.adicionar();
						break;
					case 3: 
						ag.adicionar();
						break;
					case 4: 
						af.listar();
						break;
					case 5: 
						ag.listar();
						break;
				
					case 6: 
						ag.incisoB(6);//precio <= 6
						break;
						
					case 7: 
						af.inciso(5, "holaaa");
						break;		
					case 8: 
						af.eli("holaaa");
						break;								
						
					case 9: Console.WriteLine("Fin programa!!!");
							break;
				}
			}while(op != 9);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}