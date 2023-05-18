
char gender;
double height, weight, IMC;
bool op = true;

while (op)
{
    Console.WriteLine("Qual o seu gênero? M para Mulher H para Homem");
    gender = Convert.ToChar(Console.ReadLine());

    if (gender != 'M' && gender != 'H')
    {
        Console.WriteLine("É apenas os caracteres informados, tente novamente!!!!!");
        break;
    }

    Console.WriteLine("Qual a sua altura em metros?");
    height = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Qual o seu peso?");
    weight = Convert.ToDouble(Console.ReadLine());

    IMC = weight / (height * height);

    if (gender == 'M')
    {
        if (IMC < 20.7)
            Console.WriteLine($"Abaixo do peso! IMC = {IMC:F2}");
        else if (IMC >= 20.7 && IMC < 26.5)
            Console.WriteLine($"Peso ideal! IMC = {IMC:F2}");
        else if (IMC >= 26.6 && IMC < 27.8)
            Console.WriteLine($"Pouco acima do peso! IMC = {IMC:F2}");
        else if (IMC > 27.9 && IMC < 31.1)
            Console.WriteLine($"Acima do peso! IMC = {IMC:F2}");
        else
            Console.WriteLine($"Obesidade! IMC = {IMC:F2}");
    }
    else
    {
        if (IMC < 19.1)
            Console.WriteLine($"Abaixo do peso! IMC = {IMC:F2}");
        else if (IMC >= 19.1 && IMC < 25.8)
            Console.WriteLine($"Peso ideal! IMC = {IMC:F2}");
        else if (IMC >= 25.9 && IMC < 27.3)
            Console.WriteLine($"Pouco acima do peso! IMC = {IMC:F2}");
        else if (IMC >= 27.4 && IMC < 32.3)
            Console.WriteLine($"Acima do peso! IMC = {IMC:F2}");
        else
            Console.WriteLine($"Obesidade! IMC = {IMC:F2}");
    }
    op = false;
}