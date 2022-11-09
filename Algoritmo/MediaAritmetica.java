package mediaaritmetica;

import java.util.Scanner;

public class MediaAritmetica {

    public static void main(String[] args) {
//Fazer programa que recebe 3 notas de escreve “aprovado” se a media
//aritmética das notas for maior ou igual a seis e “reprovado” caso contrário.
      double n1, n2, n3, media;
      Scanner num = new Scanner(System.in);
      n1 = num.nextDouble();
      n2 = num.nextDouble();
      n3 = num.nextDouble();
      media = (n1 + n2 + n3)/3;
      if(media >= 6)
      {
          System.out.println("Aprovado");
      }
      else
      {
          System.out.println("Reprovado");
      }
    }
}
