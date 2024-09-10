import java.util.*;
class AmountDue{
    static double taxRate = 0.12;
    public void computeAmountDue(double price){
        double totalDue = price + (price * taxRate);
        System.out.println("Amount due is " + totalDue);
    }
    public void computeAmountDue(double price, int quantity){
        double totalDue = (price * quantity) + (price + taxRate);
        System.out.println("Amount due is " + totalDue);
    }
    public void computeAmountDue(double price, int quantity, double amountDiscount){
        double totalDue = ((price * quantity) - amountDiscount) + (price * taxRate);
        System.out.println("Amount due is " + totalDue);
    }
}
public class RunAmountDue {
public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    AmountDue due = new AmountDue();
    System.out.println("Press any of the following then enter values separated by spaces: ");
    String[]info = {"1 - Price only", "2 - Price and quantity", "3 - Price, quantity, and discount amount"};
    for(String display: info){
        System.out.println(display);
    }
    System.out.print("Select from 1, 2 or 3: ");
    int options = sc.nextInt();
    
    double price;
    int quantity;
    double amountDiscount;
    
    if (options == 1) {
        price = sc.nextDouble();
        due.computeAmountDue(price);
    } else if (options == 2) {
        price = sc.nextDouble();
        quantity = sc.nextInt();
        due.computeAmountDue(price, quantity);
    } else if (options == 3){
        price = sc.nextDouble();
        quantity = sc.nextInt();
        amountDiscount = sc.nextDouble();
        due.computeAmountDue(price, quantity, amountDiscount);
     } else {
        System.out.println("Program Terminated");
     }
    }
}
