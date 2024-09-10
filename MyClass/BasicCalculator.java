package MyClass;
import java.util.Scanner;

public class BasicCalculator {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        String continueCalculation = "yes"; // Variable to control the loop

        while (continueCalculation.equalsIgnoreCase("yes")) {
            double fNum, Snum;
            double finalValue;

            System.out.println("BasicCalculator");
            System.out.print("Enter first number: ");
            fNum = s.nextDouble();
            System.out.print("Enter second number: ");
            Snum = s.nextDouble();

            System.out.println("Choose operator:");
            System.out.println("1. Add");
            System.out.println("2. Subtract");
            System.out.println("3. Multiply");
            System.out.println("4. Divide");

            String operator = s.next();

            if (operator.equals("1")) {
                finalValue = fNum + Snum;
                System.out.println("Result: " + finalValue);
            } else if (operator.equals("2")) {
                finalValue = fNum - Snum;
                System.out.println("Result: " + finalValue);
            } else if (operator.equals("3")) {
                finalValue = fNum * Snum;
                System.out.println("Result: " + finalValue);
            } else if (operator.equals("4")) {
                if (Snum != 0) {
                    finalValue = fNum / Snum;
                    System.out.println("Result: " + finalValue);
                } else {
                    System.out.println("Error: Division by zero.");
                }
            } else {
                System.out.println("Invalid operator selected.");
            }

            System.out.print("Do you want to perform another calculation? (yes/no): ");
            continueCalculation = s.next();
        }

        System.out.println("Goodbye!");
        s.close();
    }
}
