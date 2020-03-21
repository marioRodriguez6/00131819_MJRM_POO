package com.MJRM.x00131819;

public class HerramientasMinecraft {
    private String tipo, material;
    private double daño, durabilidad, alcance;

    public HerramientasMinecraft(String tipo, String material, int daño, int durabilidad, int alcance) {
        this.tipo = tipo;
        this.material = material;
        this.daño = daño;
        this.durabilidad = durabilidad;
        this.alcance = alcance;
    }


    @Override
    public String toString() {
        return "HerramientasMinecraft{" +
                "tipo='" + tipo + '\'' +
                ", material='" + material + '\'' +
                ", daño=" + daño +
                ", durabilidad=" + durabilidad +
                ", alcance=" + alcance +
                '}';
    }

    public String getTipo() {
        return tipo;
    }

    public double getDurabilidad() {
        return durabilidad;
    }

    public void Uso(){
        this.durabilidad= this.durabilidad -1;
        System.out.println(" ");
        System.out.println("Se esta usado un -- " + this.tipo + " --"+ this.daño+ " --" + this.alcance+ "-- le ha bajado la durabilidad por el ataque, mira su nueva durabilidad --"+ this.durabilidad);
        System.out.println("---"+this.tipo+" de "+this.material+ " -----\n");
    }

    public boolean botarHerramientaPorTipo(String s){
        if(this.tipo.equals(s)){
            System.out.println("herramienta botada ");
            return true;
        }

        return false;
    }
}


