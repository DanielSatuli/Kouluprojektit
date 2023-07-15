package MySql;

import java.sql.Connection;
import java.sql.DriverManager;

class Connector {
    public static Connection getConnection() throws Exception{
        try{
            String driver = "com.mysql.oj.jdbc.Driver";
            String url = "jdbc:mysql://localhost:3307/vn?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
            String username = "root";
            String password = "admin";
            Class.forName(driver);

            Connection con =DriverManager.getConnection(url,username,password);
            System.out.println("Yhdistetty");
            return con;
        }catch(Exception e){
            System.out.println(e);
        }
        return null;
    }

}
