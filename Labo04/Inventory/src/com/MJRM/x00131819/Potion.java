package com.MJRM.x00131819;

import javax.swing.*;

public class Potion extends Health_item{
    private int amount;

    public Potion(int id, int weight, String name, String description, int reuseTime, String level, String type, int amount) {
        super(id, weight, name, description, reuseTime, level, type);
        this.amount = amount;
    }

    public void drink(){

        JOptionPane.showMessageDialog(null, "tomando pocion...");
        amount--;

    }

    @Override
    public String toString() {
        return "Potion{" +
                "amount=" + amount +
                ", reuseTime=" + reuseTime +
                ", level='" + level + '\'' +
                ", type='" + type + '\'' +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
