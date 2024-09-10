package MyClass;
import java.util.Scanner;
public class Test{
    public static void main (String[]args){
        Scanner s = new Scanner(System.in);
        
        String name1, name2, name3;
        
   System.out.println("Enter three first names: "); //asks the user to input three names
   name1 = s.nextLine();
   name2 = s.nextLine();
   name3 = s.nextLine();
   
   int ch1 = 1, ch2 = 2, ch3 = 3, ch4 = 4, ch5 = 5,ch6 = 6, select;
   System.out.println("Possible names are: ");           //this will display the possible names 
   System.out.println("1 - " + name1 + " " + name2);     //user can select the names that they like
   System.out.println("2 - " + name1 + " " + name3);
   System.out.println("3 - " + name2 + " " + name1);
   System.out.println("4 - " + name2 + " " + name3);
   System.out.println("5 - " + name3 + " " + name1);
   System.out.println("6 - " + name3 + " " + name2);
   
   System.out.println("Enter 1-6 to select a name: ");   //asks the user to select a number from 1 - 6
   select = s.nextInt();                                 //after selecting, it will display the initials for the suggested username            
   if(select == ch1){
       System.out.print("The initials for " + name1 + " " + name2 + " is ");
       char result = name1.charAt(0);
       char result2 = name2.charAt(0);
       System.out.println(result +""+ result2+".");
       System.out.println("Suggested username: "+ name1.toLowerCase()+"_"+name2.toLowerCase());
    }
    else if(select == ch2){
        System.out.print("The initials for " + name1 + " " + name3 + " is ");
       char result = name1.charAt(0);
       char result3 = name3.charAt(0);
       System.out.println(result +""+ result3+".");        
       System.out.println("Suggested username: "+ name1.toLowerCase()+"_"+name3.toLowerCase());
    }
    else if(select == ch3){
        System.out.print("The initials for " + name2 + " " + name1 + " is ");
       char result2 = name2.charAt(0);
       char result = name1.charAt(0);
       System.out.println(result2 +""+ result+".");
       System.out.println("Suggested username: "+ name2.toLowerCase()+"_"+name1.toLowerCase());
    }
        else if(select == ch4){
        System.out.print("The initials for " + name2 + " " + name3 + " is ");
       char result2 = name2.charAt(0);
       char result3 = name3.charAt(0);
       System.out.println(result2 +""+ result3+".");
       System.out.println("Suggested username: "+ name2.toLowerCase()+"_"+name3.toLowerCase());
    }
    else if(select == ch5){
        System.out.print("The initials for " + name3 + " " + name1 + " is ");
       char result3 = name3.charAt(0);
       char result = name1.charAt(0);
       System.out.println(result3 +""+ result+".");
       System.out.println("Suggested username: "+ name3.toLowerCase()+"_"+name1.toLowerCase());
    }
    else if(select == ch6){
        System.out.print("The initials for " + name3 + " " + name2 + " is ");
       char result3 = name3.charAt(0);
       char result2 = name2.charAt(0);
       System.out.println(result3+""+ result2+".");
       System.out.println("Suggested username: "+ name3.toLowerCase()+"_"+name2.toLowerCase());
    }
}
}