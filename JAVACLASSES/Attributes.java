package JAVACLASSES;

public class Attributes {
    int x;
    int y = 20;
    public static void main(String[] args) {
        Attributes a = new Attributes();
        a.x = 10;
        a.y = 23;
        int result = a.x + a.y;
        System.out.println(a.x);
        System.out.println(a.y);
        System.out.println("The result of x + y is " + result);
    }
}
