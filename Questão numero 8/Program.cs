double[] faturamentoDiario = { 100, 23, 45, 300, 400, 300, 200, 1000, 1002, 2003 }; // Insira os valores de faturamento aqui

double menorFaturamento = double.MaxValue;
double maiorFaturamento = double.MinValue;
int diasAcimaMedia = 0;
double totalFaturamento = 0;
int diasComFaturamento = 0;


for (int dia = 0; dia < faturamentoDiario.Length; dia++)
{
    
    if (faturamentoDiario[dia] == 0) continue;

    menorFaturamento = Math.Min(menorFaturamento, faturamentoDiario[dia]);
    maiorFaturamento = Math.Max(maiorFaturamento, faturamentoDiario[dia]);

    totalFaturamento += faturamentoDiario[dia];
    diasComFaturamento++;
}

double mediaFaturamento = totalFaturamento / diasComFaturamento;

for (int dia = 0; dia < faturamentoDiario.Length; dia++)
{
    if (faturamentoDiario[dia] > mediaFaturamento) diasAcimaMedia++;
}

Console.WriteLine("Menor faturamento diário: " + menorFaturamento);
Console.WriteLine("Maior faturamento diário: " + maiorFaturamento);
Console.WriteLine("Media de faturamento anual: " + mediaFaturamento);
Console.WriteLine("Dias com faturamento acima da média: " + diasAcimaMedia);