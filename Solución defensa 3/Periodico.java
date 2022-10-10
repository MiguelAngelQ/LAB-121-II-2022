
public class Periodico {
	protected String nom;
	protected int nroArt;
	protected String[][] art = new String[50][3];
	protected int nroPag[] = new int[50];

	public Periodico() {
		nom = "El deber";
		nroArt = 2;
		// articulo 1
		art[0][0] = "Halloween";
		art[0][1] = "Rescatistas frenan adopciones de gatos negros y blancos para evitar que sean sacrificados en rituales satánicos";
		art[0][2] = "Elizabeth La Fuente";
		nroPag[0] = 9;
		// articulo 2
		art[1][0] = "Premio Nobel";
		art[1][1] = "Mañana se conocerá al ganador o ganadores del Nobel en Economía 2022";
		art[1][2] = "Anonimo";
		nroPag[1] = 15;
	}

	public Periodico(String nom) {
		this.nom = nom;
		nroArt = 3;
		// articulo 1
		art[0][0] = "Halloween";
		art[0][1] = "Rescatistas frenan adopciones de gatos negros y blancos para evitar que sean sacrificados en rituales satánicos";
		art[0][2] = "Elizabeth La Fuente";
		nroPag[0] = 7;
		// articulo 2
		art[1][0] = "Turismo";
		art[1][1] = "El 80% de los bolivianos que viaja a España lo hace por turismo o de visita a sus familiares";
		art[1][2] = "Milenka Rivera";
		nroPag[1] = 1;
		// articulo 3
		art[2][0] = "Incendio en Tarija";
		art[2][1] = "El incendio forestal en la zona montañosa se ha extendidoun 60%.";
		art[2][2] = "Anonimo";
		nroPag[2] = 19;
	}

	public void mostrar() {
		System.out.println("Nombre: " + nom);
		System.out.println("Nro. de articulos: " + nroArt);
		for (int i = 0; i < nroArt; i++) {
			System.out.println("Articulo " + (i + 1) + ":");
			System.out.println("\tTitulo: " + art[i][0]);
			System.out.println("\tTexto: " + art[i][1]);
			System.out.println("\tAutor: " + art[i][2]);
		}
	}

	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public int getNroArt() {
		return nroArt;
	}

	public void setNroArt(int nroArt) {
		this.nroArt = nroArt;
	}

	public String getArt(int i, int j) {
		return art[i][j];
	}
}
