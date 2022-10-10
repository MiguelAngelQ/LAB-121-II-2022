
public class PeMensual extends PeNacional {
	private String mes;

	public PeMensual() {
		mes = "Septiembre";
	}

	public PeMensual(String nom, String depto, String mes) {
		super(nom, depto);
		this.mes = mes;
	}

	public void mostrar() {
		super.mostrar();
		System.out.println("Mes: " + mes);
		System.out.println();
	}

	public String getMes() {
		return mes;
	}

	public void setMes(String mes) {
		this.mes = mes;
	}
}
