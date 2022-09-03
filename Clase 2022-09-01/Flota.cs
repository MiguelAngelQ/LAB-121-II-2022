/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 2/9/2022
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SolucionPrimerParcial.I2022{
	/// <summary>
	/// Description of Flota.
	/// </summary>
	public class Flota{
		private string placa;
		private int capacidad, nroPasajeros;
		private string [, ]pasajeros = new string[50,4];
		
		public Flota(){
			placa = "TUP901";
			capacidad = 50;
			nroPasajeros = 3;
			//pasajero 1:
			pasajeros[0, 0] = "Alan Brito";
			pasajeros[0, 1] = "26";
			pasajeros[0, 2] = "Masculino";
			pasajeros[0, 3] = "2";
			//pasajero 2:
			pasajeros[1, 0] = "Cristina Flores";
			pasajeros[1, 1] = "25";
			pasajeros[1, 2] = "Femenino";
			pasajeros[1, 3] = "3";
			//pasajero 3:
			pasajeros[2, 0] = "Lupe Ramos";
			pasajeros[2, 1] = "21";
			pasajeros[2, 2] = "Femenino";
			pasajeros[2, 3] = "6";
		}
		
		public Flota(string placa, int capacidad){
			this.placa = placa;
			this.capacidad = capacidad;
			nroPasajeros = 3;
			pasajeros[0, 0] = "Juan Perez";
			pasajeros[0, 1] = "15";
			pasajeros[0, 2] = "Masculino";
			pasajeros[0, 3] = "9";
			//pasajero 2:
			pasajeros[1, 0] = "Cristina Flores";
			pasajeros[1, 1] = "25";
			pasajeros[1, 2] = "Femenino";
			pasajeros[1, 3] = "7";
			//pasajero 3:
			pasajeros[2, 0] = "Marcos Paredes";
			pasajeros[2, 1] = "18";
			pasajeros[2, 2] = "Masculino";
			pasajeros[2, 3] = "17";
		}
		
		//leer
		
		public void mostrar(){
			Console.WriteLine("\nplaca: " + placa);
			Console.WriteLine("capacidad: " + capacidad);
			Console.WriteLine("nroPasajeros: " + nroPasajeros);
			for(int i = 0; i < nroPasajeros; i++){
				Console.WriteLine("\tnombre: " + pasajeros[i, 0]);
				Console.WriteLine("\tedad: " + pasajeros[i, 1]);
				Console.WriteLine("\tgenero: " + pasajeros[i, 2]);
				Console.WriteLine("\tnroAsiento: " + pasajeros[i, 3]);
			}
		}
		
		public void incisoA(string generoX){
			Console.WriteLine("\n----------------Inciso A-------------------------");
			for(int i = 0; i < nroPasajeros; i++){
				if(pasajeros[i, 2] == generoX && int.Parse(pasajeros[i, 1]) >= 18){
					Console.WriteLine("\tnombre: " + pasajeros[i, 0]);
					Console.WriteLine("\tedad: " + pasajeros[i, 1]);
					Console.WriteLine("\tgenero: " + pasajeros[i, 2]);
					Console.WriteLine("\tnroAsiento: " + pasajeros[i, 3]);
				}
			}
			Console.WriteLine("--------------------------------------------------------");
		}
		
		public void incisoB(Flota x){
			Console.WriteLine("\n----------------Inciso B-------------------------");
			for(int i = 0; i < this.nroPasajeros; i++){
				bool sw = true;//este pasajero i no esta en la segunda flota
				for(int j = 0; j < x.nroPasajeros; j++){
					if(this.pasajeros[i, 0] == x.pasajeros[j, 0]){
						sw = false;//esta en la segunda flota
						break;
					}
				}
				if(sw == true){
					Console.WriteLine("\tnombre: " + pasajeros[i, 0]);
					Console.WriteLine("\tedad: " + pasajeros[i, 1]);
					Console.WriteLine("\tgenero: " + pasajeros[i, 2]);
					Console.WriteLine("\tnroAsiento: " + pasajeros[i, 3]);
				}
			}
			Console.WriteLine("--------------------------------------------------------");
		}
		
		public bool incisoC(){
			Console.WriteLine("\n----------------Inciso B-------------------------");
			bool sw = true;//Alexis es deliz en su viaje
			for(int i = 0; i < nroPasajeros; i++){
				if(pasajeros[i, 2] == "Masculino" && int.Parse(pasajeros[i, 3]) % 2 == 1){
					sw = false;
					break;
				}
				if(pasajeros[i, 2] == "Femenino" && int.Parse(pasajeros[i, 3]) % 2 == 0){
					sw = false;
					break;
				}
			}
			return sw;
		}
		
		public string getPlaca() {
			return placa;
		}
	
		public void setPlaca(string placa) {
			this.placa = placa;
		}
	
		public int getCapacidad() {
			return capacidad;
		}
	
		public void setCapacidad(int capacidad) {
			this.capacidad = capacidad;
		}
	
		public int getNroPasajeros() {
			return nroPasajeros;
		}
	
		public void setNroPasajeros(int nroPasajeros) {
			this.nroPasajeros = nroPasajeros;
		}
	}
}
