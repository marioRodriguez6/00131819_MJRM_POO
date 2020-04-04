package com.MJRM.x00131819;

public class Weapon extends Reusable_item{
    private int level;
    private String wieldType, type;
    private double speed, damage;

    public Weapon(int id, int weight, String name, String description, int remainingUses, int level, String wieldType, String type, double speed, double damage) {
        super(id, weight, name, description, remainingUses);
        this.level = level;
        this.wieldType = wieldType;
        this.type = type;
        this.speed = speed;
        this.damage = damage;
    }

    public void upgrade(){
        level++;
        speed++;
        damage++;

    }

    @Override
    public String toString() {
        return "Weapon{" +
                "level=" + level +
                ", wieldType='" + wieldType + '\'' +
                ", type='" + type + '\'' +
                ", speed=" + speed +
                ", damage=" + damage +
                ", remainingUses=" + remainingUses +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
