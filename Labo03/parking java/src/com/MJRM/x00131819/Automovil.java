package com.MJRM.x00131819;

public class Automovil {

    private String placa;
    private Ticket elTicket;

    public Automovil(String placa, Ticket elTicket) {
        this.placa = placa;
        this.elTicket = elTicket;
    }

    public String getPlaca() {
        return placa;
    }

    public Ticket getElTicket() {
        return elTicket;
    }
}
