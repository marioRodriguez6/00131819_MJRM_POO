package com.MJRM.x00131819;

import javax.swing.*;

public abstract class Reusable_item extends Item {
    protected int remainingUses;

    public Reusable_item(int id, int weight, String name, String description, int remainingUses) {
        super(id, weight, name, description);
        this.remainingUses = remainingUses;
    }

    public void reduceUse() {
        remainingUses--;

    }

    public boolean use() {
        byte opc4 = Byte.parseByte(JOptionPane.showInputDialog(null, "digite si quiere usar arma. (1. si / 2. no"));
        return opc4 == 1;
    }

    @Override
    public String toString() {
        return "Reusable_item{" +
                "remainingUses=" + remainingUses +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
