/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 29/9/2022
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Herencia_LAB_121{
	
	public class CPreparatoria : Curso{
		private String modulo, especialidad;
		
		public CPreparatoria() : base(){
			modulo = "II/2022";
			especialidad = "Sistemas Contables";
		}
		
		public CPreparatoria(int id, String nomDirector, String nroDistrito, String ciudad, String modulo, 
		                     String especialidad) : base(id, nomDirector, nroDistrito, ciudad){
			this.modulo = modulo;
			this.especialidad = especialidad;
		}
		
		public void mostrar() {
			base.mostrar();
			Console.WriteLine("modulo: " + modulo);
			Console.WriteLine("especialidad: " + especialidad);
			Console.WriteLine();
		}
		
		public void incisoB(CSecundaria x){
			if(this.cantidadEstudiantesMayoresDeEdad() > x.cantidadEstudiantesMayoresDeEdad()){
				Console.WriteLine("El curso prepa tiene mas estudiantes mayores de edad");
			}else if(x.cantidadEstudiantesMayoresDeEdad() > this.cantidadEstudiantesMayoresDeEdad()){
				Console.WriteLine("El curso secu tiene mas estudiantes mayores de edad");
			}else{
				Console.WriteLine("Ambos cursos tienen estudiantes mayores de edad en igual cantidad");
			}
			Console.WriteLine();
		}
		
		public String getModulo() {
			return modulo;
		}
	
		public void setModulo(String modulo) {
			this.modulo = modulo;
		}
	
		public String getEspecialidad() {
			return especialidad;
		}
	
		public void setEspecialidad(String especialidad) {
			this.especialidad = especialidad;
		}
	}
}
