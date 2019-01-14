/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package finalproject;
import com.teamdev.jxbrowser.chromium.Browser;
import com.teamdev.jxbrowser.chromium.swing.BrowserView;
 
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
public class GoogleMapsSample {
    
    public  void map(){
    Browser browser = new Browser();
        BrowserView view = new BrowserView(browser);

        JFrame frame = new JFrame("JxBrowser - My current location");

        
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
      frame.add(view,BorderLayout.CENTER);
        frame.setSize(500, 400);
        frame.setLocationRelativeTo(null);
       frame.setVisible(true);
       browser.loadURL("http://maps.google.com");
       
       
}
    
    
}
