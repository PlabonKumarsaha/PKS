/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mynewcourse;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.InputStream;
import java.util.Vector;
import java.util.Enumeration;


public class Main {
    
enum PlType
{
    Assembly,midlevellanguage,HighLevelLanguage,RegularLanguage
}
    public static void main(String[] args)  {
        Enumeration days;
   Vector dayNames = new Vector();
   dayNames.add("Saturday");
   dayNames.add("Monday");
   dayNames.add("Thursday");
   dayNames.add("Wensday");
   dayNames.add("Friday");
   
   days = dayNames.elements();
   while(days.hasMoreElements())
   {
       System.out.println(days.nextElement());
   }
   
   PlType lang;
   //array for enum
   PlType arr[] = PlType.values();
   for(PlType a :arr)
   {
       System.out.println(a);
       lang = PlType.valueOf("Assembly");
       System.out.println("Value is "+lang);
   }
   
      
    }
    
}
