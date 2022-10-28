package proyectointerfaz;

import java.io.IOException;

public class ProyectoInterfaz {

    public static void main(String[] args) throws IOException {
        ArchMedicina archMed = new ArchMedicina("medicina.dat");
//        archMed.crear();
//        archMed.adicionar(new Medicina("xyz456", "ibuprofeno", 15.90));
        archMed.listar();
    } 
}
