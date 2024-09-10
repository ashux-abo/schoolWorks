package JAVA_ARRAYS;

public class StoringArrays {
    public static void main(String[] args) {
        int ages[] = {1, 2, 3, 4, 5, 6, 7, 8};
        float avg, sum = 0;
        
        int length = ages.length;
       
        int lowestAge = ages[0];
        for (int age :ages) {
            sum += age;
        }

            avg = sum / length;

            System.out.println("The average is " + avg);

            for (int age : ages){
                if (age < lowestAge){
                    lowestAge = age;
                }
            }
            System.out.println("The lowest age is " + lowestAge);
        }
}
