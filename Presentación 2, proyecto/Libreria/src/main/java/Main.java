/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Micky
 */
public class Main {
    public static void main(String[] args) {
        Biblioteca a = new Biblioteca();
        Cliente x = new Cliente();
        a.agregar_Cliente(x);
        a.leer();
        a.mostrar();
    }
}
