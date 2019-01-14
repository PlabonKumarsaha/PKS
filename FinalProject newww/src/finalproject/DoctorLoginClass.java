
package finalproject;
import java.sql.*;
import javax.swing.*;
import javax.swing.JOptionPane;

public class DoctorLoginClass
{
     Connection conn=null;
    PreparedStatement pst=null;
    ResultSet rs=null;
    
    public static Connection ConnectDB()
    {
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection conn=DriverManager.getConnection("jdbc:mysql://localhost/online_doctor_nearby","root","");
            JOptionPane.showMessageDialog(null, "connected to database");
            return conn;
           }
        catch(Exception e)
        {
          JOptionPane.showMessageDialog(null, e);
          return null;
        }
    }
    
    
    
    
    
}
