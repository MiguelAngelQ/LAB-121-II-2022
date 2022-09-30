
public class CSecundaria extends Curso {// ClaseHija extends ClasePadre
	private char paralelo;
	private String nomMateria;

	public CSecundaria() {
		super();// constructor de nuestro padre
		paralelo = 'A';
		nomMateria = "Matematica";
	}

	public CSecundaria(int id, String nomDirector, String nroDistrito, String ciudad, char paralelo,
			String nomMateria) {
		super(id, nomDirector, nroDistrito, ciudad);
		this.paralelo = paralelo;
		this.nomMateria = nomMateria;
	}

	public void mostrar() {
		super.mostrar();
		System.out.println("paralelo: " + paralelo);
		System.out.println("nomMateria: " + nomMateria);
		System.out.println();
	}

	public char getParalelo() {
		return paralelo;
	}

	public void setParalelo(char paralelo) {
		this.paralelo = paralelo;
	}

	public String getNomMateria() {
		return nomMateria;
	}

	public void setNomMateria(String nomMateria) {
		this.nomMateria = nomMateria;
	}

}
