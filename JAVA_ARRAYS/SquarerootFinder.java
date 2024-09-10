package JAVA_ARRAYS;

import java.util.*;
public class SquarerootFinder {

    double value;
    double root;
    SquarerootFinder(double value){
        this.value = value;
    }
    void SquareRoot(){
        root = Math.sqrt(value);
         int wNumber = (int) value;
        System.out.println("The square root of " + wNumber
        + " is: " + root);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter a number: " );
        double value = sc.nextDouble();
        SquarerootFinder sq = new SquarerootFinder(value);
        sq.SquareRoot();
    }
}
