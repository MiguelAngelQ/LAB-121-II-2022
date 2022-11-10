
import java.io.Serializable;
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
/**
 *
 * @author Micky
 */
public class Biblioteca implements Serializable {

    private String nombre, fecha_inauguracion;
    private int nro_empleados;
    private Empleado emp[] = new Empleado[30];
    private int nro_clientes;
    private Cliente cli[] = new Cliente[10000];
    private int nro_libros;
    private Libro lib[] = new Libro[500];
    private int nro_prestamos;
    private Prestamo pre[] = new Prestamo[5000];

    public Biblioteca() {
        nombre = "DE INFO";
        fecha_inauguracion = "14/09/2001";
        nro_empleados = 0;
        nro_clientes = 0;
        nro_libros = 0;
        nro_prestamos = 0;
    }

    public void leer() {
        Scanner in = new Scanner(System.in);
        System.out.println("Nombre: ");
        nombre = in.nextLine();
        System.out.println("Fecha_inauguracion: ");
        fecha_inauguracion = in.nextLine();
        System.out.println("Nro_Empleados: ");
        nro_empleados = in.nextInt();
        in.nextLine();
        for (int i = 0; i < nro_empleados; i++) {
            emp[i] = new Empleado();
            emp[i].leer();
        }
        System.out.println("Nro_Libros: ");
        nro_libros = in.nextInt();
        in.nextLine();
        for (int i = 0; i < nro_libros; i++) {
            lib[i] = new Libro();
            lib[i].leer();
        }
        System.out.println("Nro_Prestamos: ");
        nro_prestamos = in.nextInt();
        in.nextLine();
        for (int i = 0; i < nro_prestamos; i++) {
            pre[i] = new Prestamo();
            pre[i].leer();
        }
    }

    public void agregar_Cliente(Cliente x) {
        cli[nro_clientes] = new Cliente();
        cli[nro_clientes] = x;
        nro_clientes += 1;
    }

    public void adicionar_empleado(Empleado x) {
        emp[nro_empleados] = new Empleado();
        emp[nro_empleados] = x;
        nro_empleados += 1;
    }

    public void adicionar_libro(Libro x) {
        lib[nro_libros] = new Libro();
        lib[nro_libros] = x;
        nro_libros += 1;
    }

    public void adicionar_prestamo(Prestamo x) {
        pre[nro_prestamos] = new Prestamo();
        pre[nro_prestamos] = x;
        nro_prestamos += 1;
    }
    
    public void devolver_prestamo(int id) {
        Scanner in = new Scanner(System.in);
        for(int i = 0; i < nro_prestamos; i++){
            if(pre[i].getId_prestamo() == id){
                pre[i].setEstado("Devuelto");
                System.out.println("Desea modificar la observacion? S/N:");
                String op = in.nextLine();
                if(op.equals("S")){
                    System.out.println("Introduzca la observacion: ");
                    op = in.nextLine();
                    pre[i].setObservaciones(op);
                }
                System.out.println("LIBRO DEVUELTO!!!");
            }
        }
    }

    public void ordenar_empleados_paterno() {//por ap paterno
        for (int i = 0; i < nro_empleados - 1; i++) {
            for (int j = i + 1; j < nro_empleados; j++) {
                if (emp[j].getPaterno().compareTo(emp[i].getPaterno()) > 0) {
                    Empleado x = emp[j];
                    emp[j] = emp[i];
                    emp[i] = x;
                }
            }
        }
    }

    public void eliminar_libro_id(int id) {
        for (int i = 0; i < nro_libros; i++) {
            if (lib[i].getId_libro() == id) {
                for (int j = i; j < nro_libros - 1; j++) {
                    lib[j] = lib[j + 1];
                }
                nro_libros -= 1;
                break;
            }
        }
    }
    
    public void eliminar_empleado_id(int id) {
        for (int i = 0; i < nro_empleados; i++) {
            if (emp[i].getId_empleado() == id) {
                for (int j = i; j < nro_empleados - 1; j++) {
                    emp[j] = emp[j + 1];
                }
                nro_empleados -= 1;
                break;
            }
        }
    }

    public void buscar_empleado_paterno(String pat) {//por ap paterno
        for (int i = 0; i < nro_empleados; i++) {
            if (emp[i].getPaterno().equals(pat)) {
                emp[i].mostrar();
            }
        }
    }

    public void mostrar() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Fecha_inauguracion: " + fecha_inauguracion);
        System.out.println("Nro_empleados: " + nro_empleados);
        for (int i = 0; i < nro_empleados; i++) {
            emp[i].mostrar();
        }
        System.out.println("Nro_clientes: " + nro_clientes);
        for (int i = 0; i < nro_clientes; i++) {
            cli[i].mostrar();
        }
        System.out.println("Nro_libros: " + nro_libros);
        for (int i = 0; i < nro_libros; i++) {
            lib[i].mostrar();
        }
        System.out.println("Nro_prestamos: " + nro_prestamos);
        for (int i = 0; i < nro_prestamos; i++) {
            pre[i].mostrar();
        }
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getFecha_inauguracion() {
        return fecha_inauguracion;
    }

    public void setFecha_inauguracion(String fecha_inauguracion) {
        this.fecha_inauguracion = fecha_inauguracion;
    }

    public int getNro_empleados() {
        return nro_empleados;
    }

    public void setNro_empleados(int nro_empleados) {
        this.nro_empleados = nro_empleados;
    }

    public int getNro_clientes() {
        return nro_clientes;
    }

    public void setNro_clientes(int nro_clientes) {
        this.nro_clientes = nro_clientes;
    }

    public int getNro_libros() {
        return nro_libros;
    }

    public void setNro_libros(int nro_libros) {
        this.nro_libros = nro_libros;
    }

    public int getNro_prestamos() {
        return nro_prestamos;
    }

    public void setNro_prestamos(int nro_prestamos) {
        this.nro_prestamos = nro_prestamos;
    }
}
