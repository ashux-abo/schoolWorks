package MyClass;
import java.util.Scanner;

public class TryCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String continueCalculation = "yes";
        
        while (continueCalculation.equalsIgnoreCase("yes")) {
            System.out.println("Enter the first number:");
            double num1 = scanner.nextDouble();
            
            System.out.println("Enter the second number:");
            double num2 = scanner.nextDouble();
            
            double sum = num1 + num2;
            System.out.println("The sum is: " + sum);
            
            System.out.println("Do you want to perform another calculation? (yes/no)");
            continueCalculation = scanner.next();
        }
        
        System.out.println("Calculator stopped.");
        scanner.close();
    }
}
