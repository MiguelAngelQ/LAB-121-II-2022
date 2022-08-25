import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner in =  new Scanner(System.in);
		
		SuperMercado a = new SuperMercado();
		SuperMercado b = new SuperMercado("456EFV", "Ketal", "Av. Ballivian, Esq. mercado");
		a.mostrar();
		b.mostrar();
		/*Mostrar el supermercado con menos
		stock disponible del producto de
		nombre X.*/
		System.out.print("Introduxca mnombre del producto x: ");
		String x = in.nextLine();
		if(a.stockProductX(x) < b.stockProductX(x)) {
			System.out.println(a.getNombre());
		}else if(b.stockProductX(x) < a.stockProductX(x)) {
			System.out.println(b.getNombre());
		}else {
			System.out.println("Ni uno de los dos supermercados tiene Stock o tienen el mismo stock");
		}
		/*
		 Mostrar el nombre de los productos
		que tiene el supermercado de nombre a, que son m´as baratos en el
		supermercado de nombre b.
		 */
		a.incisoD(b);
		
		//Eliminar el producto con nombre "Sublime"
		System.out.println("\nEliminando...\n");
		a.eliminarProducto("masticable");
		a.mostrar();
	}

}
