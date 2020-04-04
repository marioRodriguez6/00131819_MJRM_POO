package com.MJRM.x00131819;

public class Item {
   protected int id, weight;
   protected String name, description;

    public Item(int id, int weight, String name, String description) {
        this.id = id;
        this.weight = weight;
        this.name = name;
        this.description = description;
    }

    public Item() {

    }

    public int getId() {
        return id;
    }

    @Override
    public String toString() {
        return "Item{" +
                "id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }

    public String getDescription() {
        return description;
    }


}
