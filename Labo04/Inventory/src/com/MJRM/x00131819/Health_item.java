package com.MJRM.x00131819;

public abstract class Health_item extends Item{
    protected  int reuseTime;
    protected String level, type;

    public Health_item(int id, int weight, String name, String description, int reuseTime, String level, String type) {
        super(id, weight, name, description);
        this.reuseTime = reuseTime;
        this.level = level;
        this.type = type;
    }
    protected abstract void drink();

    @Override
    public String toString() {
        return "Health_item{" +
                "reuseTime=" + reuseTime +
                ", level='" + level + '\'' +
                ", type='" + type + '\'' +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
