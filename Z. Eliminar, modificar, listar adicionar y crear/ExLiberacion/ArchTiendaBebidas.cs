/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 21:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{
	[Serializable]
	public class ArchTiendaBebidas{
		private string nomArch;
		private Tienda_bebidas regTiendaBeb;
		
		public ArchTiendaBebidas(string nom){
			this.nomArch = nom;
		}
		public void crear(){
			if(File.Exists(nomArch))
				File.Delete(nomArch);
		}
		
		public void adicionar(){
			string op;
			Stream aTiendaBeb = File.Open(nomArch,FileMode.OpenOrCreate);
			BinaryWriter escribe = new BinaryWriter(aTiendaBeb);
			
			Console.WriteLine("----- ADICIONAR ------\n");
			try {
				
				do{
					regTiendaBeb = new Tienda_bebidas();
					

					
					regTiendaBeb.leer();
					escribe.Seek(0,SeekOrigin.End);
					regTiendaBeb.escritorbb(escribe);
					
					Console.WriteLine("desea cont s/n");
					op = Console.ReadLine();
				}while(op == "s");
			
			} catch (Exception) {
				Console.WriteLine("Fin adicion!!!");
			} finally {
				aTiendaBeb.Close();
			}
		}
		
		public void listar(){
			Stream aTiendaBeb = File.Open(nomArch, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(aTiendaBeb);
			
			Console.WriteLine("----- LISTAR ------\n");
			try {
				while(true){
					regTiendaBeb = new Tienda_bebidas();
					regTiendaBeb.lectorbb(lee);
					regTiendaBeb.mostrar();
				}
			} catch (Exception e) {
				//Console.WriteLine(e.Message);
				Console.WriteLine("fin listado!!");
				
			} finally {
				aTiendaBeb.Close();
			}
		}		
		
		public bool es_primo(int n){
			int div = 0;
			for(int i = 1; i <= n; i++)
				if(n % i == 0)
					div += 1;
			if(div == 2)
				return true;
			return false;
		}
		
		public void incisoB(int precioX){
			Stream aTiendaBeb = File.Open(nomArch, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(aTiendaBeb);
			
			Console.WriteLine("----- INCISO B ------\n");
			try {
				while(true){
					regTiendaBeb = new Tienda_bebidas();
					regTiendaBeb.lectorbb(lee);
					if(es_primo(regTiendaBeb.getNIT())){
						regTiendaBeb.mostrar(precioX);
					}
					
					regTiendaBeb.mostrar();
				}
			} catch (Exception e) {
				//Console.WriteLine(e.Message);
				Console.WriteLine("fin listado!!");
				
			} finally {
				aTiendaBeb.Close();
			}
		}		
		
	}
}
