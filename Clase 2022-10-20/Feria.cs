/*
 * Created by SharpDevelop.
 * User: Kaylen
 * Date: 20/10/2022
 * Time: 16:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Recu{
	
	public class Feria{
		private string nombre, fechaInicio, fechaFinalizacion;
		private int nroParticipantes, nroStands;
		private Participante[] pa = new Participante[30];
		private Stand[] st = new Stand[30];
		
		public Feria(Producto a, Producto b, Producto c, Producto d){
			nombre = "Ciencia y vida";
			fechaInicio = "20/10/2022";
			fechaFinalizacion = "30/10/2022";
			nroParticipantes = 0;
			nroStands = 3;
			st[0] = new Stand();
			st[0].agregarProducto(a);
			st[1] = new Stand("mediano", 2);
			st[1].agregarProducto(b);
			st[1].agregarProducto(d);
			st[2] = new Stand("pequeño", 3);
			st[2].agregarProducto(c);
		}
		
		public void mostrar(){
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("FechaInicio: " + fechaInicio);
			Console.WriteLine("FechaFinalizacion: " + fechaFinalizacion);
			Console.WriteLine("NroParticipantes: " + nroParticipantes);
			for(int i = 0; i < nroParticipantes; i++){
				pa[i].mostrar();
			}
			Console.WriteLine("NroStands: " + nroStands);
			for(int i = 0; i < nroStands; i++)
				st[i].mostrar();
			Console.WriteLine();
		}
		
		public void agregarParticipante(Participante a){
			pa[nroParticipantes] = new Participante();
			pa[nroParticipantes] = a;
			nroParticipantes += 1;
		}
		
		public void realizarCompra(string nombreProd){
			bool sw = false;//no compre nada
			for(int i = 0; i < nroStands; i++){
				if(st[i].comprar(nombreProd) == true){
					sw = true;
					break;
				}
			}
			if(sw == false){
				Console.WriteLine("No se pudo realizar la compra :(");
			}
		}
		public double mayorCapital(){
			double maximo = 0.0;
			for(int i = 0; i < nroStands; i++){
				if(st[i].montoTotal() > maximo){
					maximo = st[i].montoTotal();
				}
			}
			return maximo;
		}
		
		public void inicisoC(){
			double mx = mayorCapital();
			for(int i = 0; i < nroStands; i++){
				if(mx == st[i].montoTotal()){
					for(int j = 0; j < nroParticipantes; j++){
						if(pa[j].getCodigo() == st[i].getCodParticipante()){
							Console.WriteLine(pa[j].getNombre());
						}
					}
				}
			}
		}
	}
}
