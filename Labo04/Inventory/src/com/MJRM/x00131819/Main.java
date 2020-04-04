package com.MJRM.x00131819;

import javax.swing.*;
import java.util.ArrayList;

public class Main {
 public static void main(String[] args) {

   ArrayList<Item> PersonalItems = new ArrayList<>();
   ArrayList<Item> CommonItems = new ArrayList<>();

	int opc = 0;
	    do{
            opc = Integer.parseInt(JOptionPane.showInputDialog(null, menu1()));

	        switch(opc){

                case 1:
                    int id = ID_generator.newID();

                    String weapon = JOptionPane.showInputDialog(null, "Digite la arma que estara usando durante el juego. ");
                    int weightW = Integer.parseInt(JOptionPane.showInputDialog(null, "Peso de su arma ?"));
                    String description = JOptionPane.showInputDialog(null, "descripcion del arma");
                    int remainingUsesW = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuanta municion carga el arma ?"));
                    int level = Integer.parseInt(JOptionPane.showInputDialog(null, "Nivel del arma ?"));
                    String wieldType = JOptionPane.showInputDialog(null, "manera de agarrar el arma (una mano o ambas manos) ");
                    String type = JOptionPane.showInputDialog(null, "Tipo de arma (Bow, Sword, Staff, Orb, Dagger). ");
                    double speed = Double.parseDouble(JOptionPane.showInputDialog(null, "Que tan rapida es la arma ?"));
                    double damage = Double.parseDouble(JOptionPane.showInputDialog(null, "Cuanta daño hace el arma ?"));

                     PersonalItems.add(new Weapon(id, weightW, weapon, description, remainingUsesW, level, wieldType, type, speed, damage));


                    String potion = JOptionPane.showInputDialog(null, "Digite la pocion que estara usando durante el juego. ");
                    int weightP = Integer.parseInt(JOptionPane.showInputDialog(null, "Peso de la pocion ?"));
                    String descriptionP = JOptionPane.showInputDialog(null, "descripcion de la pocion");
                    int reuseTimeP = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuanto le queda de pocion ?"));
                    String levelP = JOptionPane.showInputDialog(null, "Nivel de la pocion ?");
                    String typeP = JOptionPane.showInputDialog(null, "Tipo de pocion (Mana or Life). ");
                    int amountP = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantas pociones de " + potion + " carga ?"));

                    PersonalItems.add(new Potion(id, weightP, potion, descriptionP, reuseTimeP, levelP, typeP, amountP));


                    String elixir = JOptionPane.showInputDialog(null, "Digite el Elixir que estara usando durante el juego. ");
                    int weightE = Integer.parseInt(JOptionPane.showInputDialog(null, "Peso del Elixir ?"));
                    String descriptionE = JOptionPane.showInputDialog(null, "descripcion del Elixir");
                    int reuseTimeE = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuanto le queda al Elixir ?"));
                    String levelE = JOptionPane.showInputDialog(null, "Nivel del Elixir ?");
                    String typeE = JOptionPane.showInputDialog(null, "Tipo de Elixir (Mana or Life). ");
                    int amountE = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantos Elixir de " + elixir + " carga ?"));
                    int timeE = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuantas tiempo dura el elixir ?"));

                    PersonalItems.add(new Elixir(id, weightE, elixir,  descriptionE, reuseTimeE, levelE, typeE, amountE, timeE));


                    int weightA = Integer.parseInt(JOptionPane.showInputDialog(null, "Peso de la municion ?"));
                    String descriptionA = JOptionPane.showInputDialog(null, "descripcion de la municion");
                    int remainingUsesA = Integer.parseInt(JOptionPane.showInputDialog(null, "Cuanta municion le queda al arma ?"));
                    boolean equipped = Boolean.parseBoolean(JOptionPane.showInputDialog(null, "tiene municion todavia ? (TRUE OR FALSE)"));

                    PersonalItems.add(new Ammo(id, weightA, weapon, descriptionA, remainingUsesA, equipped));

                    JOptionPane.showMessageDialog(null, "ID del Item que acaba de ingresar: " + id);

                    break;

                case 2:
                    int idArmaD = Integer.parseInt(JOptionPane.showInputDialog(null, "ID del arma que quiere duplicar"));
                    for (Item d : PersonalItems){
                        if( d.getId() == idArmaD){

                            CommonItems.add(d);

                            JOptionPane.showMessageDialog(null, "Se ha compartido con exito");

                        }else
                            JOptionPane.showMessageDialog(null, "no se ha encontrado Id de arma.");
                    }
                    break;

                case 3:
                    byte opc1 = Byte.parseByte(JOptionPane.showInputDialog(null, "digite en que lista quiere buscar su arma \n (1. PersonalItems     2. CommonItems)"));
                        if(opc1 == 1){
                            int IDweapon1 = Integer.parseInt(JOptionPane.showInputDialog(null, "ID del arma que quiere buscar"));
                            for (Item d : PersonalItems){
                                if( d.getId() == IDweapon1){

                                    JOptionPane.showMessageDialog(null, d.toString());

                                }else
                                    JOptionPane.showMessageDialog(null, "No se ha encontrado Id de arma en esta lista.");
                            }

                        }else if (opc1 == 2){
                            int IDweapon2 = Integer.parseInt(JOptionPane.showInputDialog(null, "ID del arma que quiere buscar"));
                            for (Item A : CommonItems){
                                if( A.getId() == IDweapon2){

                                    JOptionPane.showMessageDialog(null, A.toString());

                                }else
                                    JOptionPane.showMessageDialog(null, "No se ha encontrado Id de arma en esta lista.");
                            }
                        }else
                            JOptionPane.showMessageDialog(null, "Opcion incorrecta ! Intente de nuevo");
                    break;

                case 4:
                    byte opc2 = Byte.parseByte(JOptionPane.showInputDialog(null, "digite en que lista quiere buscar su arma \n (1. PersonalItems     2. CommonItems)"));

                    if(opc2 == 1){
                        String typeSP = JOptionPane.showInputDialog(null, "Que tipo de su Item quiere ver \n "+
                                " (Pocion, Elixir, Ammo, Weapon)");

                        PersonalItems.forEach(ds->{

                            if(typeSP.equals("Weapon") && ds instanceof Weapon){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                            if(typeSP.equals("Ammo") &&  ds instanceof Ammo){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                            if(typeSP.equals("Pocion") && ds instanceof Potion){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                            if(typeSP.equals("Elixir") &&  ds instanceof Elixir){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                        });
                    }else if(opc2 == 2){
                        String typeSC = JOptionPane.showInputDialog(null, "Que tipo de su Item quiere ver \n "+
                                " (Pocion, Elixir, Ammo, Weapon)");

                        CommonItems.forEach(ds->{
                            if (typeSC.equals("Weapon") && ds instanceof Weapon) {
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                            if(typeSC.equals("Ammo") && ds instanceof Ammo){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                            if(typeSC.equals("Pocion") && ds instanceof Potion){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                            if(typeSC.equals("Elixir") && ds instanceof Elixir){
                                JOptionPane.showMessageDialog(null, ds.toString());
                            }
                        });
                }else
                        JOptionPane.showMessageDialog(null, "Opcion incorrecta ! Intente de nuevo");
                    break;

                case 5:
                    byte opc3 = Byte.parseByte(JOptionPane.showInputDialog(null, "digite en que lista quiere buscar su arma \n (1. PersonalItems     2. CommonItems)"));
                    if(opc3 == 1){
                        int IDweaponEP = Integer.parseInt(JOptionPane.showInputDialog(null, "ID del arma que quieres eliminar."));

                        for(Item ds : PersonalItems){
                            if(ds.getId() == IDweaponEP){
                                PersonalItems.removeIf(AS-> ds.getId() == IDweaponEP);
                            }else
                                JOptionPane.showMessageDialog(null, "No se ha encontrado Id de arma en esta lista.");
                        }
                    }else if(opc3 == 2){
                        int IDweaponEC = Integer.parseInt(JOptionPane.showInputDialog(null, "ID del arma que quieres eliminar."));

                        for(Item ds : CommonItems){
                            if(ds.getId() == IDweaponEC){
                                CommonItems.removeIf(AS-> ds.getId() == IDweaponEC);
                            }else
                                JOptionPane.showMessageDialog(null, "No se ha encontrado Id de arma en esta lista.");
                        }
                    }else
                        JOptionPane.showMessageDialog(null, "Opcion incorrecta ! Intente de nuevo");
                    break;

                case 6:
                    byte opc4 = Byte.parseByte(JOptionPane.showInputDialog(null, "digite en que lista quiere buscar su arma \n (1. PersonalItems     2. CommonItems)"));

                    if(opc4 == 1){
                        String typeSPE = JOptionPane.showInputDialog(null, "Digite el tipo para borrar el item \n "+
                                " (Pocion, Elixir, Ammo, Weapon) digitar tal cual porfavor");

                                PersonalItems.removeIf(obj->(typeSPE.equals("Potion") && obj instanceof Potion));

                                PersonalItems.removeIf(obj->(typeSPE.equals("Elixir") && obj instanceof Elixir));

                                PersonalItems.removeIf(obj->(typeSPE.equals("Ammo") && obj instanceof Ammo));

                                PersonalItems.removeIf(obj->(typeSPE.equals("Weapon") && obj instanceof Weapon));

                    }else if(opc4 == 2) {
                        String typeSCE = JOptionPane.showInputDialog(null, "Digite el tipo para borrar el item \n " +
                                " (Pocion, Elixir, Ammo, Weapon) digitar tal cual porfavor");

                            CommonItems.removeIf(obj -> (typeSCE.equals("Potion") && obj instanceof Potion));

                            CommonItems.removeIf(obj -> (typeSCE.equals("Elixir") && obj instanceof Elixir));

                            CommonItems.removeIf(obj -> (typeSCE.equals("Ammo") && obj instanceof Ammo));

                            CommonItems.removeIf(obj -> (typeSCE.equals("Weapon") && obj instanceof Weapon));
                         }else
                        JOptionPane.showMessageDialog(null, "Opcion incorrecta ! Intente de nuevo");
                    break;
                case 7:
                    JOptionPane.showMessageDialog(null, "Saliendo del menu.");
                    break;
                default:
                    JOptionPane.showMessageDialog(null, "Opcion incorrecta, intente de nuevo!");
            }
	    }while(opc!=7);
	}
    static String menu1(){
        return "Ingresa un opción. \n 1. Agregar ítem. \n 2. Compartir ítem \n " +
                "3. Buscar ítem por ID \n 4. Buscar ítem por tipo \n 5. Borrar ítem por ID \n " +
                "6. Borrar ítem por tipo \n 7. Salir \n ";
    }
}
