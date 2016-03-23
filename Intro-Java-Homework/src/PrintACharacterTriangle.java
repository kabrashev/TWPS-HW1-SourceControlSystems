import java.util.Scanner;

public class PrintACharacterTriangle {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};


        String firstPart = "";
        for (int j = 0; j < n; j++) {
            firstPart = firstPart + Character.toString(alphabet[j]);
            System.out.println(firstPart);
        }

        for (int i = 0; i < n - 1; i++) {
            String secondPart = "";
            for (int j = 0; j < n - 1 - i; j++) {
                secondPart = secondPart + Character.toString(alphabet[j]);
            }

            System.out.println(secondPart);
        }


    }
}
