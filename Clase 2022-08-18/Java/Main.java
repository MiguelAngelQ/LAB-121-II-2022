package claseuno;

public class Main {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
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
		//Modificar el nombre de un gato con el nombre X
		string x = in.next();
		a.setNombre(x);
		a.mostrar();
	}

}
