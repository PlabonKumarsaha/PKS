/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mynewcourse;

import java.util.Scanner;


public class Main {
    
static int var = 10;
static
{
  //System.out.println("The value is "+var);
  //this value will get printed first
    
}
    public static void main(String[] args) {
        // TODO code application logic here
        //this method will get printed after satic
     //  System.out.println("hello\n");
       
        int a = 0b101; //this is how you take binary literal
        System.out.println(a);//this will print 5 as 101 in binary is 5
        
           Scanner myObj = new Scanner(System.in); 
           a = myObj.nextInt();
           System.out.println(a);//you will get what you input
           
        int he = 0X10A; //hexa decimal literal
        System.out.println(he);
        
        int oc = 07;
        System.out.println(oc);
        
        
        
        
        
        
        
        
    }
    
}
