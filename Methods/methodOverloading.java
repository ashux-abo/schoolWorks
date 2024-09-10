package Methods;
 
/**
 * methodOverloading
 */
public class methodOverloading {

    static int myMethod(int x, int y){
        return x + y;
    }
    static double myMethod(double x, double y){
        return x * y;
    }

    public static void main(String[] args) {
        
        int num1 = myMethod(23, 22);
        double num2 = myMethod(4.5, 3.2);

        System.out.println("result: " + num1 + "\nresult: " + num2);
    }
}