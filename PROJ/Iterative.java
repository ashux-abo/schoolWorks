package PROJ;
import java.util.*;
public class Iterative {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter number: ");
        int number = sc.nextInt();
        int product = 1;
        for(int i = 0; i < number; i++){
            product = product * (i + 1);
            System.out.println(product);
        }
    }
}
