/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 15/9/2022
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Defensa2{
	public class AgenciaViaje{
		private string nom;
		private int nbus;
		private string [,]bus = new string[50, 3];
		
		public AgenciaViaje(){
			nom = "Tour Bolivia";
			nbus = 2;
			//bus 1
			bus[0, 0] = "Abc45";
			bus[0, 1] = "50";
			bus[0, 2] = "semicama";
			//bus 2
			bus[1, 0] = "php121";
			bus[1, 1] = "25";
			bus[1, 2] = "cama";
		}
		
		public void mostrar(){
			Console.WriteLine("nombre: " + nom);
			Console.WriteLine("nro de buses: " + nbus);
			for(int i = 0; i < nbus; i++){
				Console.WriteLine("\tplaca:" + bus[i, 0]);
				Console.WriteLine("\tcapacidad:" + bus[i, 1]);
				Console.WriteLine("\ttipo:" + bus[i, 2]);
			}
			Console.WriteLine();
		}
		
		public void mostrar(string tipoX){
			for(int i = 0; i < nbus; i++){
				if(bus[i, 2] == tipoX){
					for(int j = i; j < nbus - 1; j++){
						bus[j, 0] = bus[j + 1, 0];
						bus[j, 1] = bus[j + 1, 1];
						bus[j, 2] = bus[j + 1, 2];
					}
					nbus -= 1;
					i--;
				}
			}
		}
		
		public string getNom() {
			return nom;
		}
	
		public void setNom(string nom) {
			this.nom = nom;
		}
	
		public int getNbus() {
			return nbus;
		}
	
		public void setNbus(int nbus) {
			this.nbus = nbus;
		}
	}
}
