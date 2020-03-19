package com.MJRM.x00131819;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner data = new Scanner(System.in);
        boolean checkvalid=true;
        ArrayList<Character> vocals= new ArrayList<>();
        while(checkvalid) {
            System.out.print("Ingresa un letra: ");
            char letter= data.next().charAt(0);
            switch (letter) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    vocals.add(letter);
                    break;
            }
            System.out.print("¿Deseas terminar? s/n");
            letter = data.next().charAt(0);
            checkvalid= letter == 'n';
        }
        for (Character vowel : vocals) System.out.print(vocals);
    }
}