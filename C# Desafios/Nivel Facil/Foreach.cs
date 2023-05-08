int[] numeros = new int[100];
for (int i = 0; i < 100; i++)
{
    numeros[i] = 100 - i;
}
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
