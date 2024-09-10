package MyClass;

import java.util.Scanner;
public class Day2 {
   
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String option;
        String user;
        double x;
        double y;
        double finalValue;

        System.out.println("Enter your Name: ");
        user=input.nextLine();
        System.out.println("Enter your First Number: ");
        x = input.nextDouble();
        System.out.println("Enter your Second Number:");
        y = input.nextDouble();

        System.out.println("Press 1 for Addition, Press 2 for Subtraction");
        option = input.nextLine();
        if(option == "1"){
            finalValue = x + y;
            System.out.println(finalValue);
        }
    }
}