/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 27/5/2022
 * Time: 18:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Persistencia100{
	class Program{
		public static void Main(string[] args){
			bool sw = true;
           
            while( sw ) {
                // Hacemos que el fondo y el las letras sean de colores mas atractivos
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n                                        ");
                Console.WriteLine("          MENU                          ");
                Console.WriteLine("          ====                          ");
                Console.WriteLine("                                        ");
                Console.WriteLine("1. CREAR                                ");
                Console.WriteLine("2. ADICION                              ");
                Console.WriteLine("3. LISTADO                              ");
                Console.WriteLine("4. INCISO B                              ");
                Console.WriteLine("5. INCISO C                              ");
                Console.WriteLine("6. INCISO D                              ");
                Console.WriteLine("0. SALIR                                ");
                Console.WriteLine("                                        ");
                Console.WriteLine("INTRODUSCA  UNA  OPCION             =>  ");
                // leemos un caracter si esta en el intervalo 1-3 hace las 
                // Opciones que se detallan si es 4 o otro caracter sale del programa
                // haciendo un beep
                ArchTerminal ejemplo = new ArchTerminal("Terminal.dat");
                switch( Console.ReadKey().KeyChar ) {
                    case '1':
                		Console.WriteLine();
                        ejemplo.crearNuevo();
                        break;
                    case '2':
                        Console.WriteLine();
                        ejemplo.adicionar();
                        break;
                    case '3':
                        Console.WriteLine();
                        ejemplo.listar();
                        break;
                    case '4':
                        Console.WriteLine();
                        ejemplo.incisoB();
                        break;
                    case '5':
                        Console.WriteLine();
                        ejemplo.incisoC();
                        break;
                    case '6':
                        Console.WriteLine("\n" + "Into hora X: ");
                        string hora = Console.ReadLine();
                        ejemplo.incisoD(hora);
                        break;
                default:
                        Console.WriteLine("\n   El programa ya termino  !!!");
                        Console.Beep();
                        sw = false;
                        break;
                }
            }
			Console.ReadKey(true);
		}
	}
}