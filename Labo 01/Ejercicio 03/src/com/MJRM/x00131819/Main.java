package com.MJRM.x00131819;

import java.util.Scanner;

public class Main {

    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.println("Ingrese un numero: ");
        int n = in.nextInt(); in.nextLine();
        if(n > 0)
            recursividadF(n, 1, true);
        else
            System.out.println("El numero que has introducido no se puede ejecutar. ");
    }

    static void recursividadF(int n, int num, boolean revisa){
        if(revisa){
            if(num < n){
                System.out.print(num + " ");
                num++;
                recursividadF(n, num, revisa);
            }else if(num == n){
                revisa = false;
                System.out.print(num + " ");
                num--;
                recursividadF(n, num, revisa);
            }
        }else{
            if(num > 1){
                System.out.print(num + " ");
                num--;
                recursividadF(n, num, revisa);
            }else if(num == 1)
                System.out.print(num);
        }
    }
}