
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
/**
 *
 * @author Micky
 */
public class ArchBiblioteca {

    private String nomArch;
    private Biblioteca regBib;

    public ArchBiblioteca(String nom) {
        nomArch = nom;
    }

//	crear, adicionar, listar						 
    public void crear() throws FileNotFoundException, IOException {
        ObjectOutputStream archAvi = new ObjectOutputStream(new FileOutputStream(nomArch));
        archAvi.close();
    }

    public void adicionar(Biblioteca X) throws IOException {
        ObjectOutputStream archBib = null;
        try {
            if (!new File(nomArch).exists()) {
                archBib = new ObjectOutputStream(new FileOutputStream(nomArch, true));
            } else {
                archBib = new AddObjectOutputStream(new FileOutputStream(nomArch, true));
            }

            archBib.writeObject(X);
        } catch (Exception e) {
            System.out.println(e);
        } finally {
            archBib.close();
        }
    }

    public void listar() throws IOException {
        ObjectInputStream ArchBib = null;
        try {
            ArchBib = new ObjectInputStream(new FileInputStream(nomArch));
            while (true) {
                regBib = (Biblioteca) ArchBib.readObject();
                regBib.mostrar();
            }
        } catch (Exception e) {
            System.out.println("----  Fin del Listado!!  ----");
        } finally {
            ArchBib.close();
        }
    }

    public void eliminar(String X) throws IOException {//elimina toda una biblioteca
        ObjectInputStream archAvi = null;
        ObjectOutputStream archAvi2 = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            archAvi2 = new ObjectOutputStream(new FileOutputStream("copia.dat", true));
            while (true) {
                regBib = new Biblioteca();
                regBib = (Biblioteca) archAvi.readObject();
                if (!regBib.getNombre().equals(X)) {
                    archAvi2.writeObject(regBib);
                }
            }
        } catch (Exception e) {
            System.out.println("----  Se elimino las bibliotecas de nombre X ----");
        } finally {
            archAvi.close();
            archAvi2.close();
            File f1 = new File(nomArch);
            f1.delete();
            File f2 = new File("copia.dat");
            f2.renameTo(f1);
        }
    }

    public void eliminar_libro(String nomBiblio, int idLibro) throws IOException {//elimina toda una biblioteca
        ObjectInputStream archAvi = null;
        ObjectOutputStream archAvi2 = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            archAvi2 = new ObjectOutputStream(new FileOutputStream("copia.dat", true));
            while (true) {
                regBib = new Biblioteca();
                regBib = (Biblioteca) archAvi.readObject();
                if (regBib.getNombre().equals(nomBiblio)) {
                    regBib.eliminar_libro_id(idLibro);
                }
                archAvi2.writeObject(regBib);
            }
        } catch (Exception e) {
            System.out.println("----  Se elimino el libro de la biblioteca de nombre " + nomBiblio + " ----");
        } finally {
            archAvi.close();
            archAvi2.close();
            File f1 = new File(nomArch);
            f1.delete();
            File f2 = new File("copia.dat");
            f2.renameTo(f1);
        }
    }

    public void agregar_cliente(String nombibli, Cliente d) throws IOException {
        ObjectInputStream archAvi = null;
        ObjectOutputStream archAvi2 = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            archAvi2 = new ObjectOutputStream(new FileOutputStream("copia.dat", true));
            while (true) {
                regBib = new Biblioteca();
                regBib = (Biblioteca) archAvi.readObject();
                if (regBib.getNombre().equals(nombibli)) {
                    regBib.agregar_Cliente(d);
                }
                archAvi2.writeObject(regBib);
            }
        } catch (Exception e) {
            System.out.println("----  Se agrego el cliente de nombre " + d.getNombre() + " ----");
        } finally {
            archAvi.close();
            archAvi2.close();
            File f1 = new File(nomArch);
            f1.delete();
            File f2 = new File("copia.dat");
            f2.renameTo(f1);
        }
    }

    public void adicionar_prestamo(String nombibli, Prestamo d) throws IOException {
        ObjectInputStream archAvi = null;
        ObjectOutputStream archAvi2 = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            archAvi2 = new ObjectOutputStream(new FileOutputStream("copia.dat", true));
            while (true) {
                regBib = new Biblioteca();
                regBib = (Biblioteca) archAvi.readObject();
                if (regBib.getNombre().equals(nombibli)) {
                    regBib.adicionar_prestamo(d);
                }
                archAvi2.writeObject(regBib);
            }
        } catch (Exception e) {
            System.out.println("----  Se agrego el prestamo ----");
        } finally {
            archAvi.close();
            archAvi2.close();
            File f1 = new File(nomArch);
            f1.delete();
            File f2 = new File("copia.dat");
            f2.renameTo(f1);
        }
    }

    public void realizar_devolucion(String nombibli, int idPrestamo) throws IOException {
        ObjectInputStream archAvi = null;
        ObjectOutputStream archAvi2 = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            archAvi2 = new ObjectOutputStream(new FileOutputStream("copia.dat", true));
            while (true) {
                regBib = new Biblioteca();
                regBib = (Biblioteca) archAvi.readObject();
                if (regBib.getNombre().equals(nombibli)) {
                    regBib.devolver_prestamo(idPrestamo);
                }
                archAvi2.writeObject(regBib);
            }
        } catch (Exception e) {
            System.out.println("----  Se agrego el prestamo ----");
        } finally {
            archAvi.close();
            archAvi2.close();
            File f1 = new File(nomArch);
            f1.delete();
            File f2 = new File("copia.dat");
            f2.renameTo(f1);
        }
    }
}
