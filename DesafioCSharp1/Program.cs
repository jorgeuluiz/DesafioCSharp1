using System.Globalization;

class Program
{
    static void Main()
    {
        //Exercicio1();
        //Exercicio2();
        //Exercicio3();
        //Exercicio4();
        //Exercicio5();
        //Exercicio6();
    }

    static void Exercicio1()
    {
        Console.WriteLine("Qual seu nome? ");
        var nome = Console.ReadLine();

        Console.WriteLine($"Olá {nome}! Seja muito bem-vindo!");
    }

    static void Exercicio2()
    {
        Console.WriteLine("Qual seu nome? ");
        var nome = Console.ReadLine();

        Console.WriteLine("Qual seu sobrenome? ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"Olá {nome} {sobrenome}!");
    }

    static void Exercicio3()
    {
        Console.Write("Digite o primeiro numero: ");
        var input1 = Console.ReadLine();
        var valor1 = Convert.ToInt32(input1);

        Console.Write("Digite o segundo numero: ");
        var input2 = Console.ReadLine();
        var valor2 = Convert.ToInt32(input2);

        var soma = valor1 + valor2;
        var subtracao = valor1 - valor2;
        var multiplicacao = valor1 * valor2;
        var divisao = valor1 / valor2;
        var media = (valor1 + valor2) / 2;

        Console.WriteLine($"A soma entre {valor1} e {valor2} é {soma} ");
        Console.WriteLine($"A subtração entre {valor1} e {valor2} é {subtracao} ");
        Console.WriteLine($"A multiplicação  entre {valor1} e {valor2} é {multiplicacao} ");
        Console.WriteLine($"A divisão entre {valor1} e {valor2} é {divisao} ");
        Console.WriteLine($"A média entre {valor1} e {valor2} é {media} ");

    }

    static void Exercicio4()
    {
        Console.WriteLine("Digite o uma ou mais palavras: ");
        var input = Console.ReadLine();

        if (input.Length > 0)
        {
            var inputSemEspacos = input.Replace(" ", "").Trim();
            Console.WriteLine($"A quantidade de caracteres que a palavra inserida tem: {inputSemEspacos.Length}");
        }

    }

    static void Exercicio5()
    {
        Console.WriteLine("Digite uma placa de um veículo: ");
        var input = Console.ReadLine();

        if (input.Length == 7)
        {
            var letras = input.Substring(0, 3);
            foreach (var t in letras)
            {
                if (!char.IsLetter(t))
                {
                    Console.WriteLine("Falso");
                    return;
                }
            }

            var numeros = input.Substring(3);
            foreach (var t in numeros)
            {
                if (!char.IsNumber(t))
                {
                    Console.WriteLine("Falso");
                    return;
                }                
            }

            Console.WriteLine("Verdadeiro");
            return;

        }
        
        Console.WriteLine("Falso");
        
        
    }

    static void Exercicio6()
    {
        var dataHoraCompleta = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        var date = DateTime.Now.Date.ToString("dd/MM/yyyy");
        var mesPorExtenso = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
        var horaAtual = DateTime.Now.ToString("HH:mm:ss");

        Console.WriteLine(dataHoraCompleta);
        Console.WriteLine(date);
        Console.WriteLine(horaAtual);
        Console.WriteLine(mesPorExtenso);
    }
}
