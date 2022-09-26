/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 26/9/2022
 * Time: 12:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefensaB{
	
	public class Aerolinea{
		
		private int nAviones;
		private string[,] av = new string[50,2];
		private int nEmp;
		private string[,] em = new string[50,3];//la ultima columna guarda el sueldo
		
		public Aerolinea(){
			nAviones = 1;
			//avion 1
			av[0, 0] = "Airbus 330";
			av[0, 1] = "gasolina";
			nEmp = 3;
			//empleado 1
			em[0, 0] = "Juan Perez";
			em[0, 1] = "piloto";
			em[0, 2] = "7500";
			//empleado 2
			em[1, 0] = "Pedro Condori";
			em[1, 1] = "copiloto";
			em[1, 2] = "4700";
			//empleado 3
			em[2, 0] = "Mariana Mantilla";
			em[2, 1] = "azafata";
			em[2, 2] = "4000";
		}
		
		public Aerolinea(bool sw){
			nAviones = 1;
			//avion 1
			av[0, 0] = "Airbus 440";
			av[0, 1] = "gasolina";
			nEmp = 1;
			//empleado 1
			em[0, 0] = "Antonio Paredes";
			em[0, 1] = "piloto";
			em[0, 2] = "7700";
		}
		
		public void mostrar(){
			Console.WriteLine("Nro de aviones: " + nAviones);
			for(int i = 0; i < nAviones; i++){
				Console.WriteLine("\tModelo: " + av[i, 0]);
				Console.WriteLine("\tCombustible: " + av[i, 1]);
			}
			Console.WriteLine("Nro de empleados: " + nEmp);
			for(int i = 0; i < nEmp; i++){
				Console.WriteLine("\tNombre: " + em[i, 0]);
				Console.WriteLine("\tCargo: " + em[i, 1]);
				Console.WriteLine("\tsueldo: " + em[i, 2]);
			}
			Console.WriteLine();
		}
		
		public void incrementar(int x){
			for(int i = 0; i < x; i++){
				Console.Write("Introduzca modelo del avion: ");
				av[nAviones, 0] = Console.ReadLine();
				Console.Write("Introduzca combustible del avion: ");
				av[nAviones, 1] = Console.ReadLine();
				nAviones += 1;
			}
			Console.WriteLine();
		}
		
		public void incrementar(int z, string w){
			for(int i = 0; i < nEmp; i++){
				if(em[i, 1] == w){
					em[i, 2] = Convert.ToString(Convert.ToInt32(em[i, 2]) + z);
				}
			}
		}
		
		public static Aerolinea operator+(Aerolinea a, Aerolinea b){
			for(int i = 0; i < b.nAviones; i++){
				a.av[a.nAviones, 0] = b.av[i, 0];
				a.av[a.nAviones, 1] = b.av[i, 1];
				a.nAviones += 1;
			}
			for(int i = 0; i < b.nEmp; i++){
				a.em[a.nEmp, 0] = b.em[i, 0];
				a.em[a.nEmp, 1] = b.em[i, 1];
				a.em[a.nEmp, 2] = b.em[i, 2];
				a.nEmp += 1;
			}
			return a;
		}
	}
}
