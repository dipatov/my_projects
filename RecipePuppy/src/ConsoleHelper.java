import java.util.Scanner;

public class ConsoleHelper {
    private Scanner scanner=new Scanner(System.in);

    public void writeLine(String string){
        System.out.println(string);
    }

    public String readLine(){
        return scanner.nextLine();
    }
}
