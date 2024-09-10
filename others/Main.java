package others;
import java.util.*;

public class Main{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int input;

        try {
            input = sc.nextInt();
            System.out.println("Press 1 to say the n-word");
            if(input == 1){
                throw new RacistException("nigga");
            }
        }catch (InputMismatchException e) {
            System.out.println(e);
        }catch (RacistException t){
            System.out.println(t.getMessage());
        }
    }
}
class RacistException extends Exception {
    public RacistException (String message){
        super(message);
    }
}