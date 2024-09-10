package Methods;

//void does not return values
/*in order to return the values, you need to use the primitive data type (String, Integer) instead of void
and use the return key word*/
import java.util.*;
public class ReturnValues {
    static int myMethod(int x){ //in this case we use the int data type
        return x * 2; //so that we can return the value of x
    }
    static int mySecondaryMethod(int a, int b){ 
        return a + b; //we can return the sum of a and b
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println(myMethod(5)); //the result will be (5 * 2) which will be equals to 10

        System.out.print("enter value of a: ");
        int a = sc.nextInt();
        System.out.print("enter value of b: ");
        int b = sc.nextInt();
        sc.close();

        System.out.println("The sum of a and b is " + mySecondaryMethod( a, b));
    }
}

