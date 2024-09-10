package JAVACLASSES;
import java.util.Scanner;
public class ClassesAndObjects {
    int x;
    String name = "Ashley";
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ClassesAndObjects cls = new ClassesAndObjects();
        System.out.print("Enter a number: ");
        int number = scanner.nextInt();
        scanner.close();
        cls.x = number * 2;
        System.out.println("The result of x is " + cls.x);
        System.out.println("Your name is " + cls.name);
    }
}
