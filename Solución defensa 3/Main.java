
public class Main {

	public static void main(String[] args) {
		// Inciso A
		PeSemanal a = new PeSemanal();
		PeMensual b = new PeMensual("Los tiempos", "Cochabamba", "Enero");
		PeMensual c = new PeMensual("La Razon", "La Paz", "Julio");
		a.mostrar();
		b.mostrar();
		c.mostrar();

		// Inciso B
		a.incisoB("Incendio en Tarija");
		b.incisoB("Incendio en Tarija");
		c.incisoB("Incendio en Tarija");

		// Inciso C
		if (a.getNroArt() <= b.getNroArt() && a.getNroArt() <= c.getNroArt())
			System.out.println(a.getNom());
		if (b.getNroArt() <= a.getNroArt() && b.getNroArt() <= c.getNroArt())
			System.out.println(b.getNom());
		if (c.getNroArt() <= a.getNroArt() && c.getNroArt() <= b.getNroArt())
			System.out.println(c.getNom());
		System.out.println();

		// Inciso D
		a.incisoD(c, b);
	}
}
