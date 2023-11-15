using System;
using System.Data;

class Program
{
    // QUESTAO 01
    static void Main()
    {
        /**
        int a = 10;
        int b = 20;
        int auxiliar;

        Console.WriteLine("\n valor de A: " +  a);
        Console.WriteLine("\n valor de B: " +  b);

        auxiliar = a;
        a = b;
        b = auxiliar;


        Console.WriteLine("\n\n valor de A: " + a);
        Console.WriteLine("\n valor de B: " + b);
        **/
        /**
        // QUESTAO 02

        int totaleleitores;
        int votobranco;
        int votonulo;
        int votovalido;
        int percentualBrancos;
        int percentualNulos;
        int percentualValidos;

        Console.Write("Informe o número total de eleitores: ");
        totaleleitores = int.Parse(Console.ReadLine());

        Console.Write("Informe o número total de votos brancos: ");
        votobranco = int.Parse(Console.ReadLine());

        Console.Write("Informe o número total de votos nulos: ");
        votonulo = int.Parse(Console.ReadLine());

        Console.Write("Informe o número total de votos validos: ");
        votovalido = int.Parse(Console.ReadLine());

        percentualBrancos = 100 *  votobranco / totaleleitores;
        percentualNulos = 100 * votonulo / totaleleitores;
        percentualValidos = 100 * votovalido / totaleleitores;

        Console.WriteLine("Percentual de votos brancos:" + percentualBrancos + "%");
        Console.WriteLine("Percentual de votos nulos: " + percentualNulos + "%");
        Console.WriteLine("Percentual de votos válidos:" + percentualValidos + "%");
        **/
        /**
        // QUESTAO 03

        int numero;

        Console.WriteLine("Digite um numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine(" SEU NUMERO É POSITIVO: " + numero);
        }
        else
        {
            Console.WriteLine(" SEU NUMERO É NEGATIVO: " + numero);
        }
        **/
        /**
        // QUESTAO 04  
        double salarioFixo;
        double Vendas;
        double comissao;
        double salarioTotal;

        Console.Write("Digite o salário fixo do vendedor: ");
        salarioFixo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor das vendas efetuadas pelo vendedor: ");
        Vendas = double.Parse(Console.ReadLine());

       
        if (Vendas <= 1500)
        {
            comissao = Vendas * 0.03; 
        }
        else
        {
            comissao = (1500 * 0.03) + ((Vendas - 1500) * 0.05);
        }

        salarioTotal = salarioFixo + comissao;

        Console.WriteLine("O salário total do vendedor é: " + salarioTotal);
        **/

        /**
        // QUESTAO 05 

        String time1;
        String time2;
        int gol1;
        int gol2;

        Console.WriteLine("Digite o TIME 1: ");
        time1 = Console.ReadLine();

        Console.WriteLine(" <<< GOLS >>> ");
        gol1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o TIME 2: ");
        time2 = Console.ReadLine();

        Console.WriteLine(" <<< GOLS >>> ");
        gol2 = int.Parse(Console.ReadLine());

        if (gol1 > gol2){
            Console.WriteLine(" O VENCEDOR É: " + time1);
        }
        else if (gol2 > gol1){
            Console.WriteLine(" O VENCEDOR É: " + time2);
        }
        else{
            Console.WriteLine(" EMPATE ENTRE OS TIMES! ");
        }

        **/

        /**
        // QUESTAO 06

        int num1;
        int num2;
        float resultado;

        Console.WriteLine("Digite o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Digite o segundo valor (não pode ser zero): ");
            num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("O segundo valor não pode ser zero. Tente novamente.");
            }
        } while (num2 == 0);

        resultado = num1 / num2;
        Console.WriteLine("Resultado da divisao: " + resultado); 
        **/
        /**
        // QUESTAO 07
        int x = 8;
        int y = 1;
        int resultado;

        Console.WriteLine("TABUADA DO 8 \n");

        for (y= 1; y<=10; y++)
        {
            resultado = x * y;
            Console.WriteLine(x + " x " + y + " = " + resultado);
        }
        **/
        /**
        // QUESTAO 08
        int x;
        int quantidade= 10;
        int valores;
        int soma = 0; 
        double media;

        for ( x = 1; x <= quantidade; x++)
        {
            Console.Write("Digite os valores: ");
            valores = int.Parse(Console.ReadLine());

            soma += valores;
        }

        media = soma / quantidade;

        Console.WriteLine("A média aritmética dos valores é: " + media);

        
        **/

        // QUESTAO 09

        /**

        int nota1, nota2, nota3;
        double resultado;
        char letra;

        Console.WriteLine(" Digite a primeira nota = ");
        nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite a segunda nota = ");
        nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite a terceira nota = ");
        nota3 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite o tipo de media (A, P ou H) >> ");
        letra = char.Parse(Console.ReadLine());

       
        CalcularMedia(nota1, nota2, nota3, letra, out resultado);

        Console.WriteLine(" A media do aluno é >>> " + resultado);

    }
    static void CalcularMedia(int nota1, int nota2, int nota3, char letra, out double resultado)
    {
        resultado = 0;

        switch (letra)
        {
            case 'A':
                // Média Aritmética
                resultado = (nota1 + nota2 + nota3) / 3;
                break;
            case 'P':
                // Média Ponderada (pesos: 5, 3 e 2)
                resultado = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
                break;
            case 'H':
                // Média Harmônica
                resultado = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
                break;
            default:
                Console.WriteLine("Tipo de média inválido. Use 'A', 'P' ou 'H'.");
                break;
        }
        **/
        /**
        // QUESTAO 10
        double altura;
        char sexo;
        double pesoIdeal;

        Console.WriteLine(" Digite sua altura em metros >>> ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(" Digite seu sexo F (feminino) ou M (masculino) >>> ");
        sexo = char.Parse(Console.ReadLine());

        pesoIdeal = CalcularPesoIdeal(altura, sexo);

        Console.WriteLine("O peso ideal é: " + pesoIdeal + "KG");

        static double CalcularPesoIdeal(double altura, char sexo)
        {
            if (sexo == 'M' || sexo == 'm')
            {
                return 72.7 * altura - 58;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                return 62.1 * altura - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido. Use 'M' para masculino e 'F' para feminino.");
                return 0;
            }
        }

        **/
    }

}
    


       