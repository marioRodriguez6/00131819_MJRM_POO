package com.MJRM.x00131819;

import javax.swing.*;

public class Ammo extends Reusable_item {
    private boolean equipped;

    public Ammo(int id, int weight, String name, String description, int remainingUses, boolean equipped) {
        super(id, weight, name, description, remainingUses);
        this.equipped = equipped;
    }

    public void equip(){

        JOptionPane.showMessageDialog(null, "Equipando arma");

    }

    @Override
    public String toString() {
        return "Ammo{" +
                "equipped=" + equipped +
                ", remainingUses=" + remainingUses +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
