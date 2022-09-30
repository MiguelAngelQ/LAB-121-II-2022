
public class Main {

	public static void main(String[] args) {
		CSecundaria a = new CSecundaria();
		CPreparatoria b = new CPreparatoria(2, "Tania Tarquino", "17C", "Santa Cruz de la Sierra", "I/2023", "Ciencias Puras");
		//A
		a.mostrar();
		b.mostrar();
		//B
		b.incisoB(a);
		//C
		String ci = "10052678";
		if(a.existeEstudiante(ci) && a.getCiudad().equals("Santa Cruz de la Sierra")){
			System.out.println("Si se encuentra cursando");
		}else if(b.existeEstudiante(ci) && b.getCiudad().equals("Santa Cruz de la Sierra")){
			System.out.println("Si se encuentra cursando");
		}else{
			System.out.println("No encuentra cursando");
		}
	}
}
