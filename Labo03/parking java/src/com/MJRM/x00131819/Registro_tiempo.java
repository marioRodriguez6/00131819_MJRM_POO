package com.MJRM.x00131819;

public class Registro_tiempo{

    private Ticket elTicket;

    public Registro_tiempo(Ticket elTicket) {
        this.elTicket = elTicket;
    }

    public int getEstadia() {
        return elTicket.getSalida() - elTicket.getEntrada();
    }

}
