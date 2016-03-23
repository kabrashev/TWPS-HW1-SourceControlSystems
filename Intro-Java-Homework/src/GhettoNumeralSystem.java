import java.util.Scanner;

import static java.lang.System.out;

public class GhettoNumeralSystem {
    public static void main(String[] args) {
        String name = "";
        String output = "";
        out.println("Input:");
        Scanner in = new Scanner(System.in);
        String input = in.next();
        for (int i = 0; i < input.length(); i++) {
            char key = input.charAt(i);

            switch (key) {
                case '0':
                    name = "Gee";
                    break;
                case '1':
                    name = "Bro";
                    break;
                case '2':
                    name = "Zuz";
                    break;
                case '3':
                    name = "Ma";
                    break;
                case '4':
                    name = "Duh";
                    break;
                case '5':
                    name = "Yo";
                    break;
                case '6':
                    name = "Dis";
                    break;
                case '7':
                    name = "Hood";
                    break;
                case '8':
                    name = "Jam";
                    break;
                case '9':
                    name = "Mack";
                    break;
            }
            output = output + name;
        }
        out.println("Output:");
        out.println(output);
    }
}
