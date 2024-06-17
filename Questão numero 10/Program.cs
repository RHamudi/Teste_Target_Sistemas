static int SomarEMultiplicar(int numero1, int numero2, out int produto)
{
    int soma = numero1 + numero2;
    produto = numero1 * numero2;
    return soma;
}

int num1 = 10;
int num2 = 5;
int soma, produto;

soma = SomarEMultiplicar(num1, num2, out produto);

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Produto: " + produto);