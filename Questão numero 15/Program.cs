
// Limites inferior e superior
int inicio = 100;
int fim = 200;

// Fórmula para somatória de ímpares em um intervalo
int soma = (fim - inicio + 1) * (inicio + fim) / 2;

// Verificação se o limite inferior é ímpar
if (inicio % 2 == 0) {
    soma--; // Ajusta a soma se o limite inferior for par
}

// Apresentação do resultado
Console.WriteLine($"Soma dos números ímpares entre {inicio} e {fim}: {soma}");
    
