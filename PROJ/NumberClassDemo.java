package PROJ;

class NumberClass{
    public static int num = 0;
    public static void displayNumber(){
        System.out.println(num);
    }
}
public class NumberClassDemo {
    public static void main(String[] args) {
        System.out.println(NumberClass.num);
        NumberClass.displayNumber();
    }
}
