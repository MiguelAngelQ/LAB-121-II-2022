/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 27/5/2022
 * Time: 18:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Persistencia100{
	public class ArchTerminal{
		private string na;//nombre de archivo;
        private Bus rLib;//el objeto que guardara nuestro archivo
		public ArchTerminal(string nombreArchivo){
        	na = nombreArchivo;
		}
        public void crearNuevo() {
            if(System.IO.File.Exists(na) ) {//verificamos si el aerchivo existe
                Console.WriteLine("Realmente quiere borrar el archivo?. s/n");
                if( Console.ReadKey().KeyChar == 's' )//pregunta si el usuario ingreso "s"
                    System.IO.File.Delete(na);//borra el archivo con nombre na
            }
            else
                Console.WriteLine("El archivo no existe.");
        }
        public void adicionar() {
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.Append);
            BinaryWriter escribe = new BinaryWriter(arch);
            rLib = new Bus();
            try {
                do {
                    rLib.leer();
                    rLib.escribir(escribe);
                    Console.Write("Desea continuar añadiendo libros? s/n : ");
                } while( Console.ReadKey().KeyChar == 's' );
            }
            catch( Exception  ) {
                Console.WriteLine("Fallo en adicionar el objeto !!!");
            }
            finally {
                arch.Close();
            }
        }
        public void listar() {
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            rLib =new Bus();
            try {
                while( true ) {
                    rLib.lectura(lee);
                    rLib.mostrar();
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
            }
        }
        public void incisoB() {
        	int cont = 0;
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            rLib =new Bus();
            try {
                while( true ) {
                    rLib.lectura(lee);
                    if(rLib.getNroPasajeros() > 25){
                    	rLib.mostrar();
                    	cont += 1;
                    }
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
                if(cont == 0){
                	Console.WriteLine("Ni un bus tiene mas de la mitad de pasajeros");
                }
            }
        }
        public void incisoC() {
        	int cont = 0;
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            rLib =new Bus();
            try {
                while( true ) {
                    rLib.lectura(lee);
                    //verificar si hay menores de edad
                    bool sw = false;
                    for(int i = 0; i < rLib.getNroPasajeros(); i++){
                    	if(rLib.getI(i).getEdad() < 18){
                    		sw = true;
                    	}
                    }
                    if(sw == true){
                    	cont += 1;
                    	Console.WriteLine("Bus: " + rLib.getMatricula());
                    	for(int i = 0; i < rLib.getNroPasajeros(); i++){
	                    	if(rLib.getI(i).getEdad() < 18){
                    			Console.WriteLine("\t" + rLib.getI(i).getAsiento());
	                    	}
	                    }
                    }
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
                if(cont == 0){
                	Console.WriteLine("Ni un pasajero es menor de edad");
                }
            }
        }
   
        public void incisoD(string horaX) {//hh/mm/ss
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            
            //copia, aca guardermos los objetos modificados o los que nos convengan
            Stream arch2 = File.Open("copia.dat", FileMode.OpenOrCreate);
            BinaryWriter escribe = new BinaryWriter(arch2);
            
        
            try {
                while( true ) {
            		rLib =new Bus();
                    rLib.lectura(lee);
                    //ignoraremos al rchivo que queremos borrar
                    //solo guardaremos los objetos distintos a esa hora
                    if(rLib.getHora() != horaX){
                    	rLib.escribir(escribe);
                    }
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
                arch2.Close();
                
                File.Replace("copia.dat", na, na +".back");
                
            }
        }
	}
}