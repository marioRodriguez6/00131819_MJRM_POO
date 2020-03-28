package com.MJRM.x00131819;

public class Ticket {

    private int horaIN, minutoIN, horaOUT, minutoOUT;
    private String  placa;

    public Ticket(int horaIN, int minutoIN, String placa) {
        this.horaIN = horaIN;
        this.minutoIN = minutoIN;
        this.placa = placa;
    }

    public String getPlaca() {
        return placa;
    }

    public void setTimeOUT(int horaOUT, int minutoOUT) {
        this.horaOUT = horaOUT;
        this.minutoOUT = minutoOUT;
    }

    public int getEntrada() {
        return horaIN * 60 + minutoIN;

    }

    public int getSalida() {
        return horaOUT * 60 + minutoIN;
    }

    @Override
    public String toString() {
        return "Ticket {placa = '" + placa +"', Entrada = "+horaIN+":"+minutoIN +"}";
    }


}

