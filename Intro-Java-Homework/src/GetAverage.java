import java.util.Scanner;

import static java.lang.System.out;


public class GetAverage {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        out.print("Enter a: ");
        double a = Double.parseDouble(input.nextLine());
        out.print("Enter b: ");
        double b = Double.parseDouble(input.nextLine());
        out.print("Enter c: ");
        double c = Double.parseDouble(input.nextLine());

        getAverage(a, b, c);
    }

    public static void getAverage(double a1, double b1, double c1) {
        double average = (a1 + b1 + c1) / 3.00;
        out.printf("Average number is: " + "%.2f", average);
    }
}

