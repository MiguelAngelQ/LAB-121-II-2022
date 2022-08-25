import java.util.Scanner;

public class SuperMercado {
	private String ci;
	private String nombre;
	private String direccion;
	private int nroProductos;
	private String productos[][] = new String[50][3];
	
	public SuperMercado() {
		ci = "17ERT";
		nombre = "Las Brisas";
		direccion = "Av. montenegro, Esq. Murillo, No. 123";
		nroProductos = 3;
		//producto 0
		productos[0][0] = "masticable";
		productos[0][1] = "250";
		productos[0][2] = "0.05";
		//producto 1
		productos[1][0] = "bacon";
		productos[1][1] = "50";
		productos[1][2] = "0.99";
		//producto 1
		productos[2][0] = "sublime";
		productos[2][1] = "47";
		productos[2][2] = "3.50";
	}
	
	public SuperMercado(String ci, String nombre, String direccion, String nomProd, String stockProd, String PrecioProd) {
		this.ci = ci;
		this.nombre = nombre;
		this.direccion = direccion;
		nroProductos = 1;
		productos[0][0] = nomProd;
		productos[0][1] = stockProd;
		productos[0][2] = PrecioProd;
	}
	
	public SuperMercado(String ci, String nombre, String direccion) {
		this.ci = ci;
		this.nombre = nombre;
		this.direccion = direccion;
		nroProductos = 3;
		//producto 0
		productos[0][0] = "masticable";
		productos[0][1] = "250";
		productos[0][2] = "0.10";
		//producto 1
		productos[1][0] = "bacon";
		productos[1][1] = "50";
		productos[1][2] = "1.00";
		//producto 1
		productos[2][0] = "sublime";
		productos[2][1] = "47";
		productos[2][2] = "3.00";
	}
	
	public void leer() {
		Scanner in = new Scanner(System.in);
		System.out.print("Introduzca ci: ");
		ci = in.nextLine();
		System.out.print("Introduzca nombre: ");
		nombre = in.nextLine();
		System.out.print("Introduzca direccion: ");
		direccion = in.nextLine();
		System.out.print("Introduzca nro de productos: ");
		nroProductos = in.nextInt();
		for(int i = 0; i < nroProductos; i++) {
			System.out.print("Introduzca nombre del producto " + i + ": ");
			productos[i][0] = in.nextLine();
			System.out.print("Introduzca stock del producto " + i + ": ");
			productos[i][1] = in.nextLine();
			System.out.print("Introduzca precio del producto " + i + ": ");
			productos[i][2] = in.nextLine();
		}
	}
	
	public void mostrar(){
		System.out.println(ci + ", " + nombre + ", " + direccion + ", " + nroProductos);
		for(int i = 0; i < nroProductos; i++) {
			System.out.println(productos[i][0] + ", " + productos[i][1] + ", " + productos[i][2]);
		}
		System.out.println();
	}
	
	public int stockProductX(String x) {
		int cantidad = 0;
		for(int i = 0; i < nroProductos; i++) {
			if(productos[i][0].equals(x)) {//ese producto tiene nombre x
				cantidad = cantidad + Integer.parseInt(productos[i][1]);
			}
		}
		return cantidad;
	}
	
	public void incisoD(SuperMercado a) {
		for(int i = 0; i < this.nroProductos; i++) {
			for(int j = 0; j < a.nroProductos; j++) {
				if(a.productos[j][0].equals(this.productos[i][0])) {
					if(Double.parseDouble(a.productos[j][2]) < Double.parseDouble(this.productos[i][2])) {
						System.out.println(this.productos[i][0]);
					}
				}
			}
		}
	}
	
	public void eliminarProducto(String x) {
		for(int i = 0; i < nroProductos; i++) {
			if(x.equals(productos[i][0])) {
				for(int j = i; j < nroProductos - 1; j++) {
					productos[j][0] = productos[j + 1][0];
					productos[j][1] = productos[j + 1][1];
					productos[j][2] = productos[j + 1][2];
				}
				nroProductos = nroProductos - 1;
				break;
			}
		}
	}

	public String getCi() {
		return ci;
	}

	public void setCi(String ci) {
		this.ci = ci;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getDireccion() {
		return direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public int getNroProductos() {
		return nroProductos;
	}

	public void setNroProductos(int nroProductos) {
		this.nroProductos = nroProductos;
	}	
}
