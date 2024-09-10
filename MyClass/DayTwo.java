package MyClass;

import java.util.Scanner;
public class DayTwo {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String userName;
        String option;
        System.out.print("Enter your name:");
        userName = input.nextLine();

        System.out.println("is user hansam ba?");
        System.out.println("Type 1 if yes, then 2 if no");
        option = input.nextLine();
        if(option.equals("1")){
            System.out.println("you are hansam");
        }else{
            System.out.println("is user byutipul");
            System.out.println("Type 1 if yes, then 2 if no");
            option = input.nextLine();
            if(option.equals("1")){
                System.out.println("byutipul");
            }else{
                System.out.println("ang pangit mo");
            }
        }

    }
}

/*if pogiif pangitif maganda
 input == hansam valueOf (converting)
  nested if else yung loob neto may if else*/
