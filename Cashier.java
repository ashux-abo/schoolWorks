import java.util.*;
public class Cashier {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int changedOwed;

        while(true){
            System.out.print("Changed owed: ");
            if(sc.hasNextInt()){
                changedOwed = sc.nextInt();
                if(changedOwed >= 0){
                    break;
                } 
            } else {
                sc.next();
            }
            System.out.println("Invalid input because you can only enter a positive number.");
        }
        int quarters = 25, dimes = 10, nickels = 5, pennies = 1;
        int coinCount = 0;

         coinCount += changedOwed / quarters;
         changedOwed = changedOwed % quarters;

         coinCount = coinCount + changedOwed / dimes;
         changedOwed = changedOwed % dimes;

         coinCount = coinCount + changedOwed / nickels;
         changedOwed = changedOwed % nickels;

         coinCount = coinCount + changedOwed / pennies;
         
         System.out.println(coinCount);

         sc.close();

    }
}

//input user
//calculation change
