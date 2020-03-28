package com.MJRM.x00131819;

public class Moneda {
    private int cinco;
    private int diez;
    private int cora;
    private int dolar;

    public Moneda(int cinco, int diez, int cora, int dolar) {
        this.cinco = cinco;
        this.diez = diez;
        this.cora = cora;
        this.dolar = dolar;
    }

    public double consultarTotal(){
        return 1.0 * dolar
                + 0.25 * cora
                + 0.05 * cinco
                + 0.10 * diez;
    }
}