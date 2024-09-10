package others;
import java.util.*;
public class OddAndEvenChecker {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
       int x;

       while(true){
       try{
       System.out.print("Enter a number: ");
       x = sc.nextInt();

       if(x == 2){
        System.out.println("Odd");
       }
       else{
        System.out.println("Even");
       }
       }
       catch(InputMismatchException e){
        System.out.println("Only type an Integer");
       }
       finally{
        System.out.println("Please enter a number again!");
       }
    }
  }
}
