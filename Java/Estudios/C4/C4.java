package Estudios.C4;

public class C4 {
    public static void main(String[] args) {
        Object obj = new Object();
        String objString = obj.toString();

        System.err.println(obj);
        System.err.println(objString);
        
        /* 
         * Con el mismo obj
        */

        /* 
         * dará error porque obj es nulo y no puede 
         * convertir algo nulo en string. 
        */
        obj = null;
        objString = obj.toString();
        System.err.println(obj);
        System.err.println(objString);


    }
}