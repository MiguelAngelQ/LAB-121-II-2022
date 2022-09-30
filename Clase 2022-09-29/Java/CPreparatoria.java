
public class CPreparatoria extends Curso {

	private String modulo, especialidad;

	public CPreparatoria() {
		super();
		modulo = "II/2022";
		especialidad = "Sistemas Contables";
	}

	public CPreparatoria(int id, String nomDirector, String nroDistrito, String ciudad, String modulo,
			String especialidad) {
		super(id, nomDirector, nroDistrito, ciudad);
		this.modulo = modulo;
		this.especialidad = especialidad;
	}

	public void mostrar() {
		super.mostrar();
		System.out.println("modulo: " + modulo);
		System.out.println("especialidad: " + especialidad);
		System.out.println();
	}
	
	public void incisoB(CSecundaria x){
		if(this.cantidadEstudiantesMayoresDeEdad() > x.cantidadEstudiantesMayoresDeEdad()){
			System.out.println("El curso prepa tiene mas estudiantes mayores de edad");
		}else if(x.cantidadEstudiantesMayoresDeEdad() > this.cantidadEstudiantesMayoresDeEdad()){
			System.out.println("El curso secu tiene mas estudiantes mayores de edad");
		}else{
			System.out.println("Ambos cursos tienen estudiantes mayores de edad en igual cantidad");
		}
		System.out.println();
	}

	public String getModulo() {
		return modulo;
	}

	public void setModulo(String modulo) {
		this.modulo = modulo;
	}

	public String getEspecialidad() {
		return especialidad;
	}

	public void setEspecialidad(String especialidad) {
		this.especialidad = especialidad;
	}
	
}
