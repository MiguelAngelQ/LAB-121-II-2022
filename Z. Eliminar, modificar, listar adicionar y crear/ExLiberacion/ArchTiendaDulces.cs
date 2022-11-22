/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 21/11/2022
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ExLiberacion{

	[Serializable]
	public class ArchTiendaDulces{
		private string nomArch;
		private Tienda_dulces regTiendaDul;
		
		public ArchTiendaDulces(string nom){
			this.nomArch = nom;
		}
		public void crear(){
			if(File.Exists(nomArch))
				File.Delete(nomArch);
		}
		
		public void adicionar(){
			string op;
			Stream aTiendaDul = File.Open(nomArch,FileMode.OpenOrCreate);
			BinaryWriter escribe = new BinaryWriter(aTiendaDul);
			
			Console.WriteLine("----- ADICIONAR ------\n");
			try {
				
				do{
					regTiendaDul = new Tienda_dulces();
					
//					cuando se trata de agregacion!!!!
//					Medicamento m1 = new Medicamento();
//					m1.leer();
//					regFarm.adiMedicamento(m1);
//					
					regTiendaDul.leer();
					escribe.Seek(0,SeekOrigin.End);
					regTiendaDul.escritor(escribe);
					
					Console.WriteLine("desea cont s/n");
					op = Console.ReadLine();
				}while(op == "s");
			
			} catch (Exception) {
				Console.WriteLine("Fin adicion!!!");
			} finally {
				aTiendaDul.Close();
			}
		}
		
		public void listar(){
			Stream aTiendaDul = File.Open(nomArch, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(aTiendaDul);
			
			Console.WriteLine("----- LISTAR ------\n");
			try {
				while(true){
					regTiendaDul = new Tienda_dulces();
					regTiendaDul.lector(lee);
					regTiendaDul.mostrar();
				}
			} catch (Exception e) {
				//Console.WriteLine(e.Message);
				Console.WriteLine("fin listado!!");
				
			} finally {
				aTiendaDul.Close();
			}
		}		
		
		public void inciso(int nitt, string nuevonom) {//modificar
            Stream arch = File.Open(nomArch, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            
            Stream arch2 = File.Open("copia.dat", FileMode.OpenOrCreate);
            BinaryWriter escribe = new BinaryWriter(arch2);
            
        
            try {
                while( true ) {
            		regTiendaDul =new Tienda_dulces();
                    regTiendaDul.lector(lee);
                    if(regTiendaDul.getNIT() == nitt){
                    	regTiendaDul.setNombre(nuevonom);
                    	regTiendaDul.escritor(escribe);
                    }
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
                arch2.Close();
                
                File.Replace("copia.dat", nomArch, nomArch +".back");
                
            }
        }
		
		public void eli(string nomb) {//eliminar
            Stream arch = File.Open(nomArch, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            
            Stream arch2 = File.Open("copia.dat", FileMode.OpenOrCreate);
            BinaryWriter escribe = new BinaryWriter(arch2);
            
        
            try {
                while( true ) {
            		regTiendaDul =new Tienda_dulces();
                    regTiendaDul.lector(lee);
                    if(regTiendaDul.getNombre() != nomb){//solo guardan los que no van a eliminar
                    	regTiendaDul.setNombre(nomb);
                    	regTiendaDul.escritor(escribe);
                    }
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
                arch2.Close();
                
                File.Replace("copia.dat", nomArch, nomArch +".back");
                
            }
        }
		
	}
}
