/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 15/9/2022
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Defensa2{
	public class Viaje{
		private string destino, fecha, placa;
		private int np;
		private string [,]p = new string[40,4];
		
		public Viaje(){
			destino = "Oruro";
			fecha = "29-03-2022";
			placa = "php121";
			np = 3;
			//pasajero 1
			p[0, 0] = "luis";
			p[0, 1] = "01-02-2000";
			p[0, 2] = "m";
			p[0, 3] = "30";
			//pasajero 2
			p[1, 0] = "ana";
			p[1, 1] = "29-05-2016";
			p[1, 2] = "f";
			p[1, 3] = "20";
			//pasajero 3
			p[2, 0] = "rodry";
			p[2, 1] = "01-04-1995";
			p[2, 2] = "m";
			p[2, 3] = "30";
		}
		
		public Viaje(string destino, string fecha, string placa){
			this.destino = destino;
			this.fecha = fecha;
			this.placa = placa;
			np = 1;
			p[0, 0] = "mariana";
			p[0, 1] = "31-07-2001";
			p[0, 2] = "m";
			p[0, 3] = "40";
		}
		
		public void mostrar(){
			Console.WriteLine("Destino: " + destino);
			Console.WriteLine("Fecha: " + fecha);
			Console.WriteLine("Placa: " + placa);
			Console.WriteLine("Nro. Pasajeros: " + np);
			for(int i = 0; i < np; i++){
				Console.WriteLine("\tnombre: " + p[i, 0]);
				Console.WriteLine("\tfecha: " + p[i, 1]);
				Console.WriteLine("\tgenero: " + p[i, 2]);
				Console.WriteLine("\tprecio: " + p[i, 3]);
			}
			Console.WriteLine();
		}
		
		public static Viaje operator !(Viaje x){
			for(int i = 0; i < x.np; i++){
				string fechaNac = x.p[i, 1];
				string fechaActual = "15-09-2022";
				int anios = int.Parse(fechaActual.Substring(6, 4)) - int.Parse(fechaNac.Substring(6, 4));//inicioPosicion, tamanio
				//validando
				//si el mes actual es menor al mes de su nacimientos, restamos 1
				int mesActual = int.Parse(fechaNac.Substring(3, 2));
				int mesNacimiento = int.Parse(fechaNac.Substring(3, 2));
				if(mesActual < mesNacimiento){
					anios -= 1;
				}
				//si los meses son iguales, verificamos los dias
				int diaActual = int.Parse(fechaNac.Substring(0, 2));
				int diaNacimiento = int.Parse(fechaNac.Substring(0, 2));
				if(mesActual == mesNacimiento && diaActual < diaNacimiento){
					anios -= 1;
				}
				
				if(anios < 12){
					Console.WriteLine("\tnombre: " + x.p[i, 0]);
					Console.WriteLine("\tfecha: " + x.p[i, 1]);
					Console.WriteLine("\tgenero: " + x.p[i, 2]);
					Console.WriteLine("\tprecio: " + x.p[i, 3]);
				}
			}
			Console.WriteLine();
			return x;
		}
		
		public static int operator %(Viaje a, string generoX){
			//este metodo devuelve la cantidad de personas que tienen genero x
			int ans = 0;
			for(int i = 0; i < a.np; i++){
				if(a.p[i, 2] == generoX){
					ans += 1;
				}
			}
			return ans;
		}
		
		public static Viaje operator /(Viaje a, string generoX){
			//este metodo resuelve el inciso B
			Console.WriteLine("Placa: " + a.placa);
			Console.WriteLine("Destino: " + a.destino);
			int monto = 0;
			for(int i = 0; i < a.np; i++){
				if(a.p[i, 2] == generoX){
					monto += int.Parse(a.p[i, 3]);
				}
			}
			Console.WriteLine("Monto recaudado: " + monto);
			return a;
		}
		
		 public string getDestino() {
			return destino;
		}
		public void setDestino(string destino) {
			this.destino = destino;
		}
		public string getFecha() {
			return fecha;
		}
		public void setFecha(string fecha) {
			this.fecha = fecha;
		}
		public string getPlaca() {
			return placa;
		}
		public void setPlaca(string placa) {
			this.placa = placa;
		}
		public int getNp() {
			return np;
		}
		public void setNp(int np) {
			this.np = np;
		}
	}
}
