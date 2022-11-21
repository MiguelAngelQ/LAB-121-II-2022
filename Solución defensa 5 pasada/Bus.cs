/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 27/5/2022
 * Time: 18:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Persistencia100{
	[Serializable]
	public class Bus{
		private string matricula, hora;
		private int nroPasajeros;
		private Pasajero []Pasajeros = new Pasajero[50];
		
		public Bus(){
			matricula = "1940JKL";
			hora = "19:40:00";//hh:mm:ss
			nroPasajeros = 2;
			Pasajeros[0] = new Pasajero();
			Pasajeros[1] = new Pasajero("Pedro Montes", 42, "F8");
		}
		public void leer(){
			Console.WriteLine("Into matricula: ");
			matricula = Console.ReadLine();
			Console.WriteLine("Into hora: ");
			hora = Console.ReadLine();
			Console.WriteLine("Into nroPasajeros: ");
			nroPasajeros = int.Parse(Console.ReadLine());
			for(int i = 0; i < nroPasajeros; i++){
				Pasajeros[i] = new Pasajero();
				Pasajeros[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine(matricula + ", " + hora + ", " + nroPasajeros);
			for(int i = 0; i < nroPasajeros; i++){
				Pasajeros[i].mostrar();
			}
		}
		public void escribir(BinaryWriter escritor){
            escritor.Write(this.matricula);
            escritor.Write(this.hora);
            escritor.Write(this.nroPasajeros);
            for(int i = 0; i < nroPasajeros; i++){
            	Pasajeros[i].escribir(escritor);
            }
        }
        public void lectura( BinaryReader lector) {
            this.matricula = lector.ReadString();
            this.hora = lector.ReadString();
            this.nroPasajeros = lector.ReadInt32();
            for(int i = 0; i < nroPasajeros; i++){
            	Pasajeros[i].lectura(lector);
            }
        }
		 public string getMatricula() {
			return matricula;
		}
		public void setMatricula(string matricula) {
			this.matricula = matricula;
		}
		public string getHora() {
			return hora;
		}
		public void setHora(string hora) {
			this.hora = hora;
		}
		public int getNroPasajeros() {
			return nroPasajeros;
		}
		public void setNroPasajeros(int nroPasajeros) {
			this.nroPasajeros = nroPasajeros;
		}
		public Pasajero getI(int i){
			return Pasajeros[i];
		}
	}
}
