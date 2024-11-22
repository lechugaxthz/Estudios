package Estudios.C3;

public class PrivatePerson {
    private String name;
    private int age = 0;

    public void setName(String name){
        if (!name.isEmpty()) {
            this.name = name;
        }
    }
    public void setAge(int age){
        if(age > -1) {
            this.age = age;
        }
    }

    public String getName(){
        if (!this.name.isEmpty()) {
            return this.name;
        }
        return "";
    }
    public int getAge(){
        return this.age;
    }


}