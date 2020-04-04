package com.MJRM.x00131819;

import javax.swing.*;

public class Elixir extends Health_item{
    private int amount, time;

    public Elixir(int id, int weight, String name, String description, int reuseTime, String level, String type, int amount, int time) {
        super(id, weight, name, description, reuseTime, level, type);
        this.amount = amount;
        this.time = time;
    }

    public void drink(){

        JOptionPane.showMessageDialog(null, "tomando elixir...");
        amount--;
    }

    @Override
    public String toString() {
        return "Elixir{" +
                "amount=" + amount +
                ", time=" + time +
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
