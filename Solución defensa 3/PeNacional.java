
public class PeNacional extends Periodico {
	protected String depto;

	public PeNacional() {
		super();
		depto = "Santa Cruz";
	}

	public PeNacional(String nom, String depto) {
		super(nom);
		this.depto = depto;
	}

	public void mostrar() {
		super.mostrar();
		System.out.println("Departamento: " + depto);
	}

	public void incisoB(String tituloX) {
		for (int i = 0; i < nroArt; i++) {
			if (art[i][0].equals(tituloX)) {
				System.out.println("Nombre periodico: " + nom);
				System.out.println("Titulo: \n\t" + art[i][1]);
				System.out.println("Pagina:" + nroPag[i]);
				System.out.println("Departamento: " + depto);
				System.out.println();
			}
		}
	}

	public String getDepto() {
		return depto;
	}

	public void setDepto(String depto) {
		this.depto = depto;
	}

}
