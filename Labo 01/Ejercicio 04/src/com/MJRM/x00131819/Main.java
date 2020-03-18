package com.MJRM.x00131819;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner palabra = new Scanner(System.in);
        System.out.print("digite la frase a cambiar: ");
        String frase = palabra.nextLine();

        System.out.println("Antes: " + frase);
        frase = frase.replaceAll("a","b");
        System.out.println("Despues: " + frase);
    }
}
