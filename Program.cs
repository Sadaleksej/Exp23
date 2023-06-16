// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите N: ");
int i = 1;
int N = int.Parse(Console.ReadLine());
if (N<1) {
Console.WriteLine("Введено некорректное значение, попытайтесь еще");
return;
}
for(i=1; i<=N; i++) Console.WriteLine($"Куб {i} равен {Math.Pow(i,3)}");