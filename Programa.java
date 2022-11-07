
import java.util.Scanner;

public class Programa {

   
    public static void main(String[] args) {
    //Fazer programa para calcular o resto da divisão por dois numeros. Dados:numero 1 e numero 2.
        double a, b, div;
        Scanner num = new Scanner(System.in);
        a = num.nextDouble();
        b = num.nextDouble();
        div = (a/b);
        div = (a%b);
        System.out.println(div);
    }
}
