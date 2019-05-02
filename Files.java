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
import java.util.Formatter;
import java.util.Scanner;


public class Files {


    public static void main(String[] args) throws FileNotFoundException {
        // TODO code application logic here
        /* //this will include new file in the location of the project
      File dir = new File("person");
      dir.mkdir();//creates file
      String p;
      //gets the location of the file where the file was created.
      p = dir.getAbsolutePath();
      System.out.println("File location : " + p); */
        
      File dir1 = new  File("F:/trash/file");
      dir1.mkdir();
      
      dir1.getName();//name of the file ,though we have given the name here
     // dir1.delete();//will delete the file
      String path =dir1.getAbsolutePath();
      //File file
      try{
      File file1 = new File("F:/trash/file/student.txt");
         // File file1 = new File(path+"student1.txt");
      file1.createNewFile();
      System.out.println("file is created");
      }
      catch(Exception e){
          System.out.println(e);
      }
      //initializing in formating
      Formatter fr = null ;
      try{
      //Formatter fr = new Formatter("F:/trash/file/student.txt");
          //craete types
          fr = new Formatter("F:/trash/file/student.txt");
          //reads that in that file
      fr.format("%s %s \n","101","pks");
      fr.format("%s %s","102","pks");
      
      }
      catch(Exception e)
      {
          System.out.println(e);
      }
      finally
      {
          //closing the formateer
        fr.close();  
      }
      
      
      
      
    }
    
}
