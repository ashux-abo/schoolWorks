package Methods;
import java.util.*;
public class MethodParameter {
    Scanner sc = new Scanner (System.in);

    static void myParameter(String fname){
        System.out.println("Name: " + fname);
    }

    public static void main(String[] args) {
        myParameter("Ashley");
        myParameter("John");
        myParameter("Kristine");
    }
}


