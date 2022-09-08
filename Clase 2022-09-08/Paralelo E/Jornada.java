import java.util.Iterator;

public class Jornada {
	private String nom;
	private String fecha;
	private int nroAct;
	private String nomAct[] = new String[30];
	private String ac[][] = new String[30][3];

	public Jornada() {
		nom = "dia del peaton";
		fecha = "04/09/2022";
		nroAct = 3;
		// actividad 1
		nomAct[0] = "ludica";
		ac[0][0] = "ruben";
		ac[0][1] = "20";
		ac[0][2] = "plaza libertad";
		// actividad 2
		nomAct[1] = "motricidad";
		ac[1][0] = "lupe";
		ac[1][1] = "15";
		ac[1][2] = "parque las cholas";
		// actividad 3
		nomAct[2] = "deportiva";
		ac[2][0] = "gael";
		ac[2][1] = "35";
		ac[2][2] = "plaza uyuni";
	}

	public Jornada(String nom) {
		this.nom = nom;
		fecha = "11/09/2022";
		nroAct = 2;
		// actividad 1
		nomAct[0] = "deportiva";
		ac[0][0] = "javier";
		ac[0][1] = "70";
		ac[0][2] = "cancha zapata";
		// actividad 2
		nomAct[1] = "ludica";
		ac[1][0] = "aracely";
		ac[1][1] = "45";
		ac[1][2] = "plaza libertad";
	}

	public Jornada(String nom, String fecha) {
		this.nom = nom;
		this.fecha = fecha;
		nroAct = 1;
		// actividad 1
		nomAct[0] = "deportiva";
		ac[0][0] = "javier";
		ac[0][1] = "70";
		ac[0][2] = "cancha zapata";
	}

	public Jornada(String nom, String fecha, String nomActividad) {
		this.nom = nom;
		this.fecha = fecha;
		nroAct = 1;
		// actividad 1
		nomAct[0] = nomActividad;
		ac[0][0] = "javier";
		ac[0][1] = "70";
		ac[0][2] = "cancha zapata";
	}

	public Jornada(String nom, String fecha, Boolean sw) {
		this.nom = nom;
		this.fecha = fecha;
		nroAct = 0;
	}

	public void mostrar() {
		System.out.println("Nombre: " + nom);
		System.out.println("Fecha: " + fecha);
		System.out.println("NroActividades: " + nroAct);
		for (int i = 0; i < nroAct; i++) {
			System.out.println("\tNom: " + nomAct[i]);
			System.out.println("\tEncargado:" + ac[i][0]);
			System.out.println("\tNroParticipantes:" + ac[i][1]);
			System.out.println("\tLugar:" + ac[i][2]);
		}
	}

	public int menorCantParticipantes() {
		int ans = 1000000000;
		for (int i = 0; i < nroAct; i++) {
			ans = Math.min(ans, Integer.parseInt(ac[i][1]));
		}
		return ans;
	}

	public void incisoB() {
		int menor = menorCantParticipantes();
		for (int i = 0; i < nroAct; i++) {
			if (Integer.parseInt(ac[i][1]) == menor) {
				System.out.println(nomAct[i]);
			}
		}
	}

	public int maximoParticipantesEnLugarX(String lugar) {
		int ans = 0;
		for (int i = 0; i < nroAct; i++) {
			if (lugar.equals(ac[i][2])) {
				ans = Math.max(ans, Integer.parseInt(ac[i][1]));
			}
		}
		return ans;
	}

	public void incisoC(Jornada x, String lugar) {
		if (this.maximoParticipantesEnLugarX(lugar) > x.maximoParticipantesEnLugarX(lugar)) {
			System.out.println(this.fecha);
		} else if (x.maximoParticipantesEnLugarX(lugar) > this.maximoParticipantesEnLugarX(lugar)) {
			System.out.println(x.fecha);
		} else {
			System.out.println("ambos tienen mayor total de participaciones en el lugar z");
		}
	}
}
