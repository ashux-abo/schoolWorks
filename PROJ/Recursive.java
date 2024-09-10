package PROJ;
import java.util.*;
public class Recursive {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter number: ");
        int number = sc.nextInt();
        
        System.out.println(factorial(number));
        
    }
    public static int factorial(int n){
            if (n < 1){
                return 1;
            } else {
                return n * factorial(n - 1);
            }
    }
}
