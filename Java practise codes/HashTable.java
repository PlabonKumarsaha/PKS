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
import java.util.*;




public class Main {
    

    public static void main(String[] args)  {
        
        Hashtable balance = new Hashtable();
        Enumeration names;
        String str;
        double bal;
        balance.put("PKS", new Double(325.666));
        balance.put("PS", new Double(325.663));
        balance.put("ASC", new Double(143.143));
        balance.put("Komu na", new Double(325.666));
        names = balance.keys();
        while(names.hasMoreElements())
        {
            str = (String) names.nextElement();
            System.out.println(str +" : "+balance.get(str));
               
        }
        System.out.println();
        
      bal =((Double)balance.get("PKS")).doubleValue();
      balance.put("PKS", new Double (bal+1000));
      System.out.println("PKS balance is "+balance.get("PKS"));
        
    }
    
}
