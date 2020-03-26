package com.MJRM.x00131819;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        ArrayList<HerramientasMinecraft> herramientas = new ArrayList<>();
        String tipo = null, material = null;
        int daño = 0, durabilidad = 0, alcance = 0;
        byte op1 = 0;

        do {
            menuPrincipal();
            System.out.print("digite su opcion: ");
            op1 = in.nextByte();
            in.nextLine();

            switch (op1) {
                case 1:
                    System.out.print("\nTipo: ");
                    tipo = in.nextLine();
                    System.out.print("Material: ");
                    material = in.nextLine();
                    System.out.print("Daño: ");
                    daño = in.nextByte();
                    in.nextLine();
                    System.out.print("Durabilidad: ");
                    durabilidad = in.nextByte();
                    in.nextLine();
                    System.out.print("Alcance: ");
                    alcance = in.nextByte();
                    in.nextLine();

                    herramientas.add(new HerramientasMinecraft(tipo, material, daño, durabilidad, alcance));

                    break;
                case 2:

                    System.out.println(herramientas.toString());
                    break;

                case 3:
                    System.out.print("Tipo: ");
                    String type = in.nextLine();

                    herramientas.forEach((i) -> {
                        if(i.getTipo().equals(type)){
                            System.out.println(i.toString());
                        }
                    });
                    break;
                case 4:
                    System.out.print("Tipo: ");
                    String finalTipo = in.nextLine();

                    herramientas.removeIf(t -> t.botarHerramientaPorTipo(finalTipo));
                    break;
                case 5:
                    herramientas.forEach(s -> s.Uso());
                    break;
                case 6:
                    System.out.println("Saliendo del Juego....");
                    break;
                default:
                    System.out.println("opcion incorrecta..");
                    break;
            }
        }while (op1 != 6) ;
    }

    static void menuPrincipal() {
        System.out.println("\n 1. Agregar herramienta a la lista. ");
        System.out.println("2. Consultar herramientas. ");
        System.out.println("3. Consultar herramiento de un tipo. ");
        System.out.println("4. botar un tipo de herramienta. ");
        System.out.println("5. atacar con herramienta. ");
        System.out.println("6. Salir. ");
    }
}