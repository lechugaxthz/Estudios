
package Estudios.C3;

public class C3 {
    public void main(String[] args) {
        /* Diferencias de tratar con propiedades publicas y privadas de clases */

        System.err.println("Persona Publica");
        PublicPerson publicPerson = new PublicPerson("lechu", 24);
        System.err.println(publicPerson.name);
        System.err.println(publicPerson.age);

        /* cambio props de publicPerson */
        System.err.println("cambiamos los valores de la misma Persona Publica");

        publicPerson.name = "Scarlette";
        publicPerson.age = 20;

        System.err.println(publicPerson.name);
        System.err.println(publicPerson.age);


        System.err.println("Persona Privada");
        PrivatePerson privatePerson = new PrivatePerson();
        
        /* 
            no va a mostrar un obj con valores nulos Y además, son privados
            por lo que no compilaría
        */
        /* 
            System.err.println(privatePerson.name);
            System.err.println(privatePerson.age); 
        */
        System.err.println("seteamos los valores de Persona Privada");

        privatePerson.setName("Lechu");
        privatePerson.setAge(20);

        System.err.println(privatePerson.getName());
        System.err.println(privatePerson.getAge());


    }
     
}