
public class Main {

	public static void main(String[] args) {
		Jornada a = new Jornada();
		Jornada b = new Jornada("dia del estudiante");
		a.mostrar();
		b.mostrar();
		// b
		a.incisoB();
		// c
		a.incisoC(b, "plaza libertad");
	}
}
