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

	public class AplicacionMensajeria{
		private string nom;
		private int nroGrupos;
		private string [,]g = new string[50,4];
		private int nroCtos;
		private string [,]c = new string[50,2];
 		
		public AplicacionMensajeria(string nom){
			this.nom = nom;
			nroGrupos = 3;
			//grupo 1
			g[0, 0] = "LAB-121 F";
			g[0, 1] = "110";
			g[0, 2] = "02/08/2022";
			g[0, 3] = "701003";
			//grupo 2
			g[1, 0] = "Wally";
			g[1, 1] = "22";
			g[1, 2] = "15/03/2022";
			g[1, 3] = "605252";
			//grupo 3
			g[2, 0] = "Info";
			g[2, 1] = "5";
			g[2, 2] = "15/03/2022";
			g[2, 3] = "701003";
			nroCtos = 5;
			//contacto 1
			c[0, 0] = "rodrigo";
			c[0, 1] = "601020";
			//contacto 2
			c[1, 0] = "adrian";
			c[1, 1] = "706414";
			//contacto 3
			c[2, 0] = "lupe";
			c[2, 1] = "605252";
			//contacto 4
			c[3, 0] = "maria";
			c[3, 1] = "701003";
			//contacto 4
			c[4, 0] = "daniel";
			c[4, 1] = "705555";
		}
		public AplicacionMensajeria(string nom, string nomCont, string celCont){
			this.nom = nom;
			nroGrupos = 1;
			//grupo 1
			g[0, 0] = "LAB-121 E";
			g[0, 1] = "117";
			g[0, 2] = "01/08/2022";
			g[0, 3] = "670472";
			nroCtos = 2;
			//contacto 1
			c[0, 0] = nomCont;
			c[0, 1] = celCont;
			//contacto 2
			c[1, 0] = "angel";
			c[1, 1] = "670472";
		}
		public void mostrar(){
			Console.WriteLine("nombre: " + nom);
			Console.WriteLine("nroGrupos: " + nroGrupos);
			for(int i = 0; i < nroGrupos; i++){
				Console.WriteLine("\tnomGrupo: " + g[i, 0]);
				Console.WriteLine("\tnroParticipantes: " + g[i, 1]);
				Console.WriteLine("\tfechaCreacion: " + g[i, 2]);
				Console.WriteLine("\tadmin: " + g[i, 3]);
			}
			Console.WriteLine("nroContactos: " + nroCtos);
			for(int i = 0; i < nroCtos; i++){
				Console.WriteLine("\tnombre: " + c[i, 0]);
				Console.WriteLine("\tnroCelular: " + c[i, 1]);
			}
			Console.WriteLine();
		}
		public int maximaCantidadParticpantes(){
			int ans = 0;
			for(int i = 0; i < nroGrupos; i++){
				//ans = Math.Max(ans, int.Parse(g[i, 1]));
				if(int.Parse(g[i, 1]) > ans){
					ans = int.Parse(g[i, 1]);
				}
			}
			return ans;
		}
		public void inicisoB(){
			int maximo = maximaCantidadParticpantes();
			for(int i = 0; i < nroGrupos; i++){
				if(int.Parse(g[i, 1]) == maximo){
					for(int j = 0; j < nroCtos; j++){
						if(g[i, 3] == c[j, 1]){
							Console.WriteLine("nomAdmi: " + c[j, 0]);
							Console.WriteLine("fechaCreacion: " + g[i, 2]);
						}
					}
				}
			}
		}
		public bool esAdminContact(string nro){
			for(int i = 0; i < nroGrupos; i++){
				for(int j = 0; j < nroCtos; j++){
					if(nro == g[i, 3] && nro == c[j, 1]){
						return true;
					}
				}
			}
			return false;
		}
		public void incisoC(AplicacionMensajeria x){
			for(int i = 0; i < this.nroCtos; i++){
				if(esAdminContact(this.c[i, 1])){
					bool sw = true;//que ningun contactoAdmin esta en la sgunda apk
					for(int j = 0; j < x.nroCtos; j++){
						if(x.c[j, 1] == this.c[i, 1]){
							sw = false;//porque esta en la segunda apk
						}
					}
					if(sw == true){
						Console.WriteLine("nombre: " + c[i, 0]);
					}
				}
			}
			
		}
	}
}
