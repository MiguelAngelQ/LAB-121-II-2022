package claseuno;

public class Main {

	public static void main(String[] args) {
		gato a = new gato();
		gato b = new gato("michi", 7, "negro", "pequeño", "nose");
		a.mostrar();
		b.mostrar();
		//mostrar al gato con mayor edad
		if(a.getEdad() > b.getEdad()) {
			System.out.println(a.getNombre());
		}else {
			System.out.println(b.getNombre() + " tiene mas edad");
		}
	}

}
