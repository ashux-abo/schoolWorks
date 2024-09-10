package JAVA_ARRAYS;
import java.util.*;
public class ConvertMetersCent {
   private int meters;

    ConvertMetersCent(int meters){
    this.meters = meters;
   }
   public int getMeters(){
    return meters;
   }
   public void setMeters(int newMeters){
    this.meters = newMeters;
   }
   void convertCentimeters(){
    int centimeters = meters * 100;
    System.out.println(meters + " m " + "is now converted to " + centimeters + " cm");
   }

   public static void main(String[] args) {
      Scanner sc = new Scanner(System.in);
      System.out.print("Enter a number to convert it to centimeters: ");
      int meters = sc.nextInt();
      ConvertMetersCent myObj = new ConvertMetersCent(meters);
      myObj.convertCentimeters();
   }
}
