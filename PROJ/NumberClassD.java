package PROJ;

public class NumberClassD {
    public static int num = 0;
    public static void main(String[] args) {
        NumberClassD.num = 4;
        NumberClassD nc1 = new NumberClassD();
        NumberClassD nc2 = new NumberClassD();
        nc1.num = 6;
        nc2.num = 5;
        System.out.println(NumberClassD.num);
    }
}
