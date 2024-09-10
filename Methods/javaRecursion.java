package Methods;

public class javaRecursion {

    public static void main(String[] args) {
        int number =  4, result;
        result = factorial(number);
        System.out.println(number + " factorial = " + result);
    }
    public static int factorial(int k){
        if (k  != 0){
            return k * factorial(k-1);
        } else {
            return 1;
        }
    }
}