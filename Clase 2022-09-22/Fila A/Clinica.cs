/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 26/9/2022
 * Time: 12:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefensaA{
	
	public class Clinica{
		
		private string nom;
		private int nPac;
		private string [,] p = new string[50, 3];
		
		public Clinica(){
			nom = "Prosalud";
			nPac = 3;
			//paciente 1
			p[0, 0] = "123456";
			p[0, 1] = "Reservado";
			p[0, 2] = "Dr. Santamaria";
			//paciente 2
			p[1, 0] = "456789";
			p[1, 1] = "Contusiones leves, reposo";
			p[1, 2] = "Dra. Salinas";
			//paciente 3
			p[2, 0] = "456982";
			p[2, 1] = "Reposo absoluto por 6 dias";
			p[2, 2] = "Dr. Santamaria";
		}
		
		public void mostrar(){
			Console.WriteLine("Nombre Clinica: " + nom);
			Console.WriteLine("Nro Pacientes Clinica: " + nPac);
			for(int i = 0; i < nPac; i++){
				Console.WriteLine("\tCI Pac. : " + p[i, 0]);
				Console.WriteLine("\tDiagnostico Pac. : " + p[i, 1]);
				Console.WriteLine("\tMedico Pac. : " + p[i, 2]);
			}
			Console.WriteLine();
		}
		
		public void resolver(string x){
			int cnt = 0;
			for(int i = 0; i < nPac; i++){
				if(p[i, 2] == x){
					Console.WriteLine(p[i, 0]);
					cnt += 1;
				}
			}
			if(cnt == 0){
				Console.WriteLine("Ni un paciente fue atendido por el " + x);
			}
			Console.WriteLine();
		}
		
		public void resolver(Paciente a){
			bool sw = false;
			for(int i = 0; i < nPac; i++){
				if(p[i, 0] == a.getCI()){
					Console.WriteLine("El paciente " + a.getNom() + " fue atendito en esta clinica y su diagnostico es " + p[i, 1]);
					sw = true;
				}
			}
			if(sw == false){
				Console.WriteLine("El paciente " + a.getNom() + " no fue atendido en esta clinica");
			}
			Console.WriteLine();
		}
		
		public static Clinica operator %(Clinica a, string z){
			int ans = 0;
			for(int i = 0; i < a.nPac; i++){
				if(a.p[i, 1] == z){
					ans += 1;
				}
			}
			Console.WriteLine(ans + " paciente(s) tiene(n) el diagnostico " + z);
			Console.WriteLine();
			return a;
		}
	}
}
