package Estudios.C6;

import Estudios.C1.Member;

public class C6 {

    public static void main(String[] args) {
        System.err.println("prueba de C6 -> documentacion");

        Member miMember = new Member("lautaro", "rapido", 24, 1);

        System.err.println(miMember.getName());

        /* 
         * to make a documentation with the "javadoc" tool from JAVA JDK 
         * you need to be placed in the terminal out of your project
         * example: user/<this site>  out of <project>
         * 
         * then use "javadoc" -d <place1*> -subpackages <dir that include>
         *                  -sourcepath <project>
         * 
         *  .place1 = where you want to have al java doc that this tool made.
         * 
        */
 
    }
}