package com.MJRM.x00131819;

public final class ID_generator {
    private static int counter = 0;
    private ID_generator(){}

    public static int newID(){
        counter++;
        return counter;
    }


}
