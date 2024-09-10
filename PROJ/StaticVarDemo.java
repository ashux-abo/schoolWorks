package PROJ;

public class StaticVarDemo {
    static int count = 0;
    public void increment(){
        count++;
    }
    public static void main(String[] args) {
        StaticVarDemo obj1 = new StaticVarDemo();
        StaticVarDemo obj2 = new StaticVarDemo();
        obj1.increment();
        System.out.println("Obj1: count = " + obj1.count);
        obj2.increment();
        System.out.println("Obj1: count = " + obj1.count);
        System.out.println("Obj2: count = " + obj2.count);
    }
}
