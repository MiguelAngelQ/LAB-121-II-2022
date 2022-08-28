/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 28/8/2022
 * Time: 08:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Defensa1I_2022{
	
	public class RedSocial{
		private string nom;
		private int nroUsuario;
		private string[, ] u = new string[50, 3];
		
		public RedSocial(){
			nom = "facebook";
			nroUsuario = 3;
			//1
			u[0, 0] = "brito18";
			u[0, 1] = "2454545";
			u[0, 2] = "2000";
			//2
			u[1, 0] = "soilaBaca";
			u[1, 1] = "7055555";
			u[1, 2] = "2005";
			//
			u[2, 0] = "d2+k2";
			u[2, 1] = "6057070";
			u[2, 2] = "2000";
		}
		
		public void mostrar(){
			Console.WriteLine("nombre: " + nom);
			Console.WriteLine("nroUsuarios: " + nroUsuario);
			for(int i = 0; i < nroUsuario; i++){
				Console.WriteLine("usuario: " + u[i, 0] + ", nroFono: " + u[i, 1] + ", anioIngreso: " + u[i, 2]);
			}
			Console.WriteLine();
		}
		
		public void incisoB(){
			int anioReciente = 0;
			for(int i = 0; i < nroUsuario; i++){
				if(int.Parse(u[i, 2]) > anioReciente){
					anioReciente = int.Parse(u[i, 2]);
				}
			}
			
			for(int i = 0; i < nroUsuario; i++){
				if(int.Parse(u[i, 2]) == anioReciente){
					Console.WriteLine(u[i, 0]);
				}
			}
			
		}
		
		public bool verificarSiExiste(Usuario user){
			for(int i = 0; i < nroUsuario; i++){
				if(u[i, 0] == user.getNom()){
					return true;//ya existe ese usuario en la red social
				}
			}
			return false;//no existe tal usuario en la red social
		}
		
		public void agregaUsuario(Usuario user){
			if(verificarSiExiste(user) == true){
				Console.WriteLine("El usuario " + user.getNom() + " ya existe en la red social");
			}else if(2022 - user.getAnioNac() >= 18){
				u[nroUsuario, 0] = user.getNom();
				u[nroUsuario, 1] =  (user.getNroFono() + "");//convirtiendo a string
				u[nroUsuario, 2] = "2022";
				nroUsuario += 1;//nroUsuario = nroUsuario + 1
			}else{
				Console.WriteLine("El usuario " + user.getNom() + " no tiene mayoria de edad");
			}
		}
		
		public string getNom() {
			return nom;
		}
		public void setNom(string nom) {
			this.nom = nom;
		}
		public int getNroUsuario() {
			return nroUsuario;
		}
		public void setNroUsuario(int nroUsuario) {
			this.nroUsuario = nroUsuario;
		}
	}
}
