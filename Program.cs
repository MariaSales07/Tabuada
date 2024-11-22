int numero = 0;
int segundo = 0;

Console.WriteLine("Digite o numero: ");
numero = Convert.ToInt32(Console.ReadLine());

while(segundo <= 10){
    Console.WriteLine($"{segundo} X {numero} = {segundo * numero}");
    segundo++;
}

