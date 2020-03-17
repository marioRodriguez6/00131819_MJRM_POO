package com.MJRM.x00131819;

public class Main {

    public static boolean Palindromo(String palabra){
     for(int i = 0; i <palabra.length(); i++){
         if(palabra.charAt(i) != palabra.charAt(palabra.length() - i - 1)){
             return false;
         }
         return true;
     }
        return false;
    }
    public static void main(String[] args) {
        String palabra = "anitalavalatina";

        System.out.println(Palindromo(palabra));
    }
}
