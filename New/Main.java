package New;
import java.util.*;
public class Main {

    class Product{
        String productName;
        float price;
        Product(String productName, float price){
            this.productName = productName;
            this.price = price;
            System.out.println(productName + " Created");
            System.out.println("Price: " + price);
        }
    }
    class Person{
        String firstName;
        String lastName;
        char sex;
        int age;
        Person(String firstName, String lastName, char sex, int age){
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
        }
    }
    Main(){
        System.out.println("Main Created");
    }
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        Main m = new Main();
        Person p = m.new Person("Kristine", "Senora", 'F', 18);
        Person p1 = m.new Person("Ashley", "Dulay", 'm', 19);

        System.out.print("Enter Product Name: ");
        String productName = s.nextLine();
        System.out.print("Enter Product Price: ");
        float price = s.nextFloat();
        Product prod = m.new Product(productName, price); 
    }
}
