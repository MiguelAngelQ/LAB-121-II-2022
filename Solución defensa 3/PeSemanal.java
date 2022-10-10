
public class PeSemanal extends PeNacional {
	private int nroSemana;

	public PeSemanal() {
		super();
		nroSemana = 5;
	}

	public PeSemanal(String nom, String depto, int nroSemana) {
		super(nom, depto);
		this.nroSemana = nroSemana;
	}

	public void mostrar() {
		super.mostrar();
		System.out.println("Nro. de semana: " + nroSemana);
		System.out.println();
	}

	public void incisoD(PeMensual a, PeMensual b) {
		for (int i = 0; i < this.nroArt; i++) {
			for (int j = 0; j < a.nroArt; j++) {
				for (int k = 0; k < b.nroArt; k++) {
					if(this.getArt(i, 0).equals(a.getArt(j, 0)) && this.getArt(i, 1).equals(a.getArt(j, 1))
							&& this.getArt(i, 0).equals(b.getArt(k, 0)) && this.getArt(i, 1).equals(b.getArt(k, 1))){
						System.out.println(this.getArt(i, 0));
						System.out.println(this.getArt(i, 1));
					}
				}
			}
		}
	}

	public int getNroSemana() {
		return nroSemana;
	}

	public void setNroSemana(int nroSemana) {
		this.nroSemana = nroSemana;
	}
}
