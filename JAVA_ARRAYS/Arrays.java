package JAVA_ARRAYS;

public class Arrays {
    public static void main(String[] args) {
        String [] cars = {"Volvo","Honda","Chrysler"};
        System.out.println(cars.length);
        for(int i = 0; i < cars.length; i++){ //normal for loop
            System.out.println(cars[i]);
        }
        for(String i: cars){  //for each
            System.out.println(i);
        }
    }
}
