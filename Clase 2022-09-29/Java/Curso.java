
public class Curso {

	protected int id, nroEstudiantes, ciProfesor;
	protected String nomDirector, nroDistrito, ciudad, nomProfesor;
	protected String[][] estudiantes = new String[3][50];

	public Curso() {
		id = 1;
		nomDirector = "Juan Perez Perez";
		nroDistrito = "14A";
		ciudad = "La Paz";
		nroEstudiantes = 3;
		// estudiante 1
		estudiantes[0][0] = "Carlos Apaza";
		estudiantes[1][0] = "8874512";
		estudiantes[2][0] = "17";
		// estudiante 2
		estudiantes[0][1] = "Mariana Paredes";
		estudiantes[1][1] = "10052612";
		estudiantes[2][1] = "18";
		// estudiante 3
		estudiantes[0][2] = "Lourdes Mamani";
		estudiantes[1][2] = "8865163";
		estudiantes[2][2] = "16";
		nomProfesor = "Alan Espinoza Condori";
		ciProfesor = 6584630;
	}

	public Curso(int id, String nomDirector, String nroDistrito, String ciudad) {
		this.id = id;
		this.nomDirector = nomDirector;
		this.nroDistrito = nroDistrito;
		this.ciudad = ciudad;
		nroEstudiantes = 2;
		// estudiante 1
		estudiantes[0][0] = "Ramiro Ali";
		estudiantes[1][0] = "9985663";
		estudiantes[2][0] = "20";
		// estudiante 2
		estudiantes[0][1] = "Mario Marca";
		estudiantes[1][1] = "10052678";
		estudiantes[2][1] = "18";
		nomProfesor = "Maria Fernandez";
		ciProfesor = 7582651;
	}

	public void mostrar() {
		System.out.println("id: " + id);
		System.out.println("nomDirector: " + nomDirector);
		System.out.println("nroDistrito: " + nroDistrito);
		System.out.println("ciudad: " + ciudad);
		System.out.println("nroEstudiantes: " + nroEstudiantes);
		for (int i = 0; i < nroEstudiantes; i++) {
			System.out.println("\tNomEstudiante: " + estudiantes[0][i]);
			System.out.println("\tCiEstudiante: " + estudiantes[1][i]);
			System.out.println("\tEdadEstudiante: " + estudiantes[2][i]);
		}
		System.out.println("nomProfesor: " + nomProfesor);
		System.out.println("ciProfesor: " + ciProfesor);
	}

	public int cantidadEstudiantesMayoresDeEdad() {
		int cont = 0;
		for (int i = 0; i < nroEstudiantes; i++) {
			if (Integer.parseInt(estudiantes[2][i]) >= 18)
				cont += 1;
		}
		return cont;
	}

	public Boolean existeEstudiante(String ci) {
		for (int i = 0; i < nroEstudiantes; i++) {
			if (estudiantes[1][i].equals(ci)) {
				return true;
			}
		}
		return false;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getNroEstudiantes() {
		return nroEstudiantes;
	}

	public void setNroEstudiantes(int nroEstudiantes) {
		this.nroEstudiantes = nroEstudiantes;
	}

	public int getCiProfesor() {
		return ciProfesor;
	}

	public void setCiProfesor(int ciProfesor) {
		this.ciProfesor = ciProfesor;
	}

	public String getNomDirector() {
		return nomDirector;
	}

	public void setNomDirector(String nomDirector) {
		this.nomDirector = nomDirector;
	}

	public String getNroDistrito() {
		return nroDistrito;
	}

	public void setNroDistrito(String nroDistrito) {
		this.nroDistrito = nroDistrito;
	}

	public String getCiudad() {
		return ciudad;
	}

	public void setCiudad(String ciudad) {
		this.ciudad = ciudad;
	}

	public String getNomProfesor() {
		return nomProfesor;
	}

	public void setNomProfesor(String nomProfesor) {
		this.nomProfesor = nomProfesor;
	}

}
