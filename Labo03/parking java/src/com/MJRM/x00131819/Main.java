package com.MJRM.x00131819;

import javax.swing.*;
import java.util.ArrayList;

public class Main {
        public static void main(String[] args) {
        ArrayList<Automovil> autoticket = new ArrayList<>();

       int opc1;
       double monto = 0;

        do {
            opc1 = Integer.parseInt(JOptionPane.showInputDialog(null, menu()));

            switch (opc1) {
                case 1:
                    String placa = JOptionPane.showInputDialog(null, "ponga la placa del coche");
                    for (Automovil d : autoticket) {
                        if (d.getPlaca().equals(placa)) {
                            JOptionPane.showMessageDialog(null, "no se puede prro, ya hay una placa igual.");
                            break;
                        }
                    }
                    int hora = Integer.parseInt(JOptionPane.showInputDialog(null, "Hora en la que esta entrando"));
                    int minute = Integer.parseInt(JOptionPane.showInputDialog(null, "Minuto en el que esta entrando"));
                    if(hora<0 || hora>24  || minute<0 || minute>59){
                        JOptionPane.showMessageDialog(null, "Hora incorreta");
                        break;
                    }
                    autoticket.add(new Automovil(placa, new Ticket(hora, minute, placa)));
                    break;
                case 2:
                    String placa2 = JOptionPane.showInputDialog(null, "ponga la placa del coche");
                    boolean c = true;

                    for (Automovil d : autoticket) {
                        if (d.getPlaca().equals(placa2)) {
                            c = false;
                            int hora2 = Integer.parseInt(JOptionPane.showInputDialog(null, "Hora en la que estas saliendo"));
                            int minute2 = Integer.parseInt(JOptionPane.showInputDialog(null, "Minuto en el que estas saliendo"));
                            if(hora2 <0 || hora2 >24  || minute2 <0 || minute2 >59){
                                JOptionPane.showMessageDialog(null, "Hora incorreta");
                                break;
                            }
                            d.getElTicket().setTimeOUT(hora2, minute2);
                            if (d.getElTicket().getEntrada()>=d.getElTicket().getSalida()){
                                JOptionPane.showMessageDialog(null, "hora de salida debe ser mayor a la hora de entrada bro.");
                                break;
                            }
                            Registro_tiempo time = new Registro_tiempo(d.getElTicket());
                            double m = pagardinero(time.getEstadia());
                            if(pagando(m)){
                                monto += m;
                                break;
                            }else
                                JOptionPane.showMessageDialog(null, "no ingreso bien la forma de pago.");
                        }
                    }
                    autoticket.removeIf(s->s.getPlaca().equals(placa2));
                    if(c){
                    JOptionPane.showMessageDialog(null, "no encontramos el ticket en nuestra base de datos.");
                    }
                    break;
                case 3:
                    String placa1 = JOptionPane.showInputDialog(null, "ponga la placa del coche");
                    boolean a = true;
                    for (Automovil d : autoticket) {
                        if (d.getPlaca().equals(placa1)) {
                            JOptionPane.showMessageDialog(null, d.getElTicket().toString());
                            a = false;
                        }
                    }
                    if (a){
                        JOptionPane.showMessageDialog(null, "no encontramos el ticket en nuestra base de datos.");
                        break;
                    }
                    break;
                case 4:
                    JOptionPane.showMessageDialog(null, "Monto total de ingresos: \n $"+monto);
                    break;
                case 5:
                    JOptionPane.showMessageDialog(null, "Saliendo del menu.");
                    break;
                default:
                    JOptionPane.showMessageDialog(null, "Opcion incorrecta mi bro.");
            }
        }while (opc1 != 5) ;
    }
    static String menu(){
        return "Ingresa un opción. \n 1-Ingresar al parqueo \n 2-Pagar ticket y salir \n " +
                "3-Consultar ticket \n 4-Monto total \n 5-Salir";
    }

    public static double pagardinero(int tiempoPasado){
        if(tiempoPasado < 30){
            return 0;
        }else if(tiempoPasado < 60){
            return 0.5;
        }else if(tiempoPasado < 120){
            return 1.0;
        }else{
            return 5.0;
        }

    }

    public static boolean pagando(double money){
        JOptionPane.showMessageDialog(null, "Tienes que pagar. " + (money));
        int cinco = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantas monedas de 0.05 $ metera: "));
        int diez = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantas monedas de 0.10 $ metera: "));
        int cora = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantas monedas de 0.25 $ metera: "));
        int dolar = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantas monedas de 1.0 $ metera: "));
        Moneda dinero = new Moneda(cinco,diez, cora, dolar);

        if (money > dinero.consultarTotal())
            return false;
        else{
            JOptionPane.showMessageDialog(null, "Tu vuelto es. " + (dinero.consultarTotal() - money));
            return true;
        }
    }
}
