package others;
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.*;
import java.util.*;
public class filepath {
   public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    String word;
    
    try{
    System.out.println("Write any letter");
    }catch(InputMismatchException e){
        System.out.println(e);
    }
    word = sc.nextLine();
    try{
    BufferedWriter writer = new BufferedWriter(new FileWriter("text.txt"));
    writer.write("Hello World" + word);
    writer.close();
    } catch (IOException e){
        e.printStackTrace();
    }

    Path filePath = Paths.get("text.txt");
    int count = filePath.getNameCount();
    System.out.println("Path is" + filePath.toString());
    System.out.println("File name is " + filePath.getFileName());
    System.out.println("There are " + count + " elements in the file path");
    for(int i = 0; i < count; i++){
        System.out.println("Element " + i + filePath.getName(i));
    }
   } 
}
