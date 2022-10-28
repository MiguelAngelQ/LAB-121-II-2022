package proyectointerfaz;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class ArchMedicina {
    private String nomArch;
    private Medicina regMed;

    public ArchMedicina(String nom) {
        nomArch = nom;
    }

//	crear, adicionar, listar						 
    public void crear() throws FileNotFoundException, IOException {
        ObjectOutputStream archAvi = new ObjectOutputStream(new FileOutputStream(nomArch));
        archAvi.close();
    }

    public void adicionar(Medicina X) throws IOException{
        ObjectOutputStream archMed = null;
        try {
            if (!new File(nomArch).exists())
                archMed = new ObjectOutputStream(new FileOutputStream(nomArch, true));
            else
                archMed = new AddObjectOutputStream(new FileOutputStream(nomArch, true));

            archMed.writeObject(X);
        } catch (Exception e) {
            System.out.println(e);
        } finally {
            archMed.close();
        }
    }
    
    public void listar() throws IOException {
        ObjectInputStream ArchMed = null;
        try {
            ArchMed = new ObjectInputStream(new FileInputStream(nomArch));
            while (true) {
                regMed = (Medicina) ArchMed.readObject();
                regMed.mostrar();
            }
        } catch (Exception e) {
            System.out.println("----  Fin del Listado!!  ----");
        } finally {
            ArchMed.close();
        }
    }
    
    public ArrayList <Medicina> listar2() throws IOException {
        ArrayList <Medicina> lis = new ArrayList<Medicina>();
        ObjectInputStream archAvi = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            while (true) {
                regMed = (Medicina)archAvi.readObject();
                lis.add(regMed);
            }
        } catch (Exception e) {
            System.out.println("----  Fin del Listado!!  ----");
        } finally {
            archAvi.close();
        }
        return lis;
    }


	
    public void eliminar(String X) throws IOException {
        ObjectInputStream archAvi = null;
        ObjectOutputStream archAvi2 = null;
        try {
            archAvi = new ObjectInputStream(new FileInputStream(nomArch));
            archAvi2 = new ObjectOutputStream(new FileOutputStream("copia.dat", true));
            while (true)
            {
                regMed = new Medicina();
                regMed = (Medicina)archAvi.readObject();
                if (!regMed.getCodM().equals(X))
                {					
                    archAvi2.writeObject(regMed);
                }
            }
        } catch (Exception e) {
            System.out.println("----  Se elimino las medicinas de destino X ----");
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
