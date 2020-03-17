package com.MJRM.x00131819;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner datos = new Scanner(System.in);
        System.out.print("Ingrese el numero aproximado al que finalizaria la serie: ");
        int max= datos.nextInt(); datos.nextLine();

        int num1=0, num2=1,reserv;
        while(num1 + num2 < max){
            System.out.println(num1);
            System.out.println(num2);

            reserv = num1;
            num1 = num2;

            num2 = num1 + reserv;
        }
        System.out.println(num2);
    }
}