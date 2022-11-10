
import java.io.IOException;
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
/**
 *
 * @author Micky
 */
public class Main {

    public static void main(String[] args) throws ClassNotFoundException, IOException {
        /*Biblioteca a = new Biblioteca();
        Cliente x = new Cliente();
        a.agregar_Cliente(x);
        a.leer();
        a.mostrar();*/
        ArchBiblioteca a = new ArchBiblioteca("biblio.dat");
        int op;
        Scanner in = new Scanner(System.in);
        do {
            System.out.println("\tMENU"
                    + "\n 1.CREAR"
                    + "\n 2.ADICIONAR"
                    + "\n 3.AGREGAR CLIENTE"
                    + "\n 4.REALIZAR PRESTAMO DE LIBRO"
                    + "\n 5.REALIZAR DEVOLUCION DE LIBRO"
                    + "\n 6.LISTAR"
                    + "\n 7.ELIMINAR"
                    + "\n 8.ELIMINAR LIBRO"
                    + "\n 9.SALIR");
            op = in.nextInt();
            in.nextLine();
            switch (op) {
                case 1:
                    a.crear();
                    break;
                case 2:
                    Biblioteca z = new Biblioteca();
                    z.leer();
                    a.adicionar(z);
                    break;
                case 3:
                    Cliente aux = new Cliente();
                    aux.leer();
                    a.agregar_cliente("de info", aux);
                    break;
                case 4:
                    Prestamo aux2 = new Prestamo();
                    aux2.leer();
                    a.adicionar_prestamo("de info", aux2);
                    break;
                case 5:
                    System.out.println("Into Id_prestamo");
                    int id = in.nextInt();
                    in.nextLine();
                    a.realizar_devolucion("de info", id);
                    break;
                case 6:
                    a.listar();
                    break;
                case 7:
                    System.out.println("Into nombre: ");
                    String r = in.nextLine();
                    a.eliminar(r);
                    break;
                case 8:
                    System.out.println("Into id Libro: ");
                    id = in.nextInt();
                    in.nextLine();
                    a.eliminar_libro("de info", id);
                    break;
                default:
                    break;
            }
        } while (op != 8);
    }
}
