/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mynewcourse;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStream; 
import java.util.*;




public class Main {
    
//Properties is a subclass of Hashtable.
//It is used to maintain lists of values in which the key is a String and the value is also a String.
    public static void main(String[] args)throws Exception  {
        
        Properties p = new Properties();
        OutputStream os = new FileOutputStream("text.properties");
        //this portion will create a file name text.properties in the repository where your project is located at
        p.setProperty("url", "localhost::3306/myDatabase");
        p.setProperty("UserName","PKS");
        p.setProperty("Password", "Pass");
        p.store(os, null);
        //The output is followed :
        
       /* #Wed Aug 14 17:01:07 BDT 2019
        User\ Name=PKS
        url=localhost\:\:3306/myDatabase
        Password=Pass */
        
        
        
     //Fethch data through properties   
        //Properties p1 = new Properties();
        InputStream is = new FileInputStream("text.properties");
        p.load(is);
        
        System.out.println(p.getProperty("url"));
        System.out.println(p.getProperty("UserName"));
        
        //this prints all the properties in the list!
        
        p.list(System.out);
        
        
    }
    
}
