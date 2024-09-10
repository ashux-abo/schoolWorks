import java.util.*; 

public class LabExer1 

{ 

    double num1, num2; 

     

    public static void plusFive(double num1, double num2){ 

        num1 += 5; 

        num2 += 5; 

        System.out.println(num1 + " and " + num2); 

    } 

    public static void timesTwo(double num1, double num2){ 

        num1 *= 2; 

        num2 *= 2; 

        System.out.println(num1 + " and " + num2); 

    } 

    public static void showSquared(double num1, double num2){ 

        num1 *= num1; 

        num2 *= num2; 

        System.out.println(num1 + " and " + num2); 

    } 

    public static void computePercent(double num1, double num2){ 

       double num3 = num1 / num2; 

       num3 *= 100; 

       int value = (int) num3; 

        System.out.println(num1 + " is " + value + " percent of " + num2); 

    } 

public static void main(String[] args) { 

Scanner sc = new Scanner(System.in); 

System.out.println("Enter two numbers: "); 

System.out.print("Enter first number: "); 

double num1 = sc.nextDouble(); 

System.out.print("Enter second number: "); 

double num2 = sc.nextDouble(); 

plusFive(num1, num2); 

timesTwo(num1, num2); 

showSquared(num1, num2); 

computePercent(num1, num2); 

} 

} 

 