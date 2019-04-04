/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mynewcourse;


public class Main {
    
static int var = 10;
static
{
  System.out.println("The value is "+var);
  //this value will get printed first
    
}
    public static void main(String[] args) {
        // TODO code application logic here
        //this method will get printed after satic
       System.out.println("hello\n");
       
        int a = 1_23_45;
        System.out.println(a);
        //compiler will ignore the '_'
        
        
        
        
    }
    
}
