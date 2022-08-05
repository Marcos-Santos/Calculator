/* 
App Criada por Marcos Alexandre Ledo dos Santos
.Net 6.0.302 utilizado
Para exercitar as escritas de comando do C#, principalmente,
para fixar a sintaxe dos mesmos, utilizando o curso de Fundamentos do 
C# (curso 2801), como material de apoio da plataforma balta.io 
*/

StartAplication();

static void StartAplication()
{
    Console.Clear();
    CalculatorTitle();
    string option = Console.ReadLine();
    SelectFunction(option);
}



static void FunctionSum()
{
    Console.Clear();
    CalculatorTitle();
    Console.WriteLine("#            Soma Selecionado            #");
    CalculatorFisrtNumber();
    double fisrtNumber = double.Parse(Console.ReadLine());
    CalculatorSecondNumber();
    double secondNumber = double.Parse(Console.ReadLine());

    CalculatorResult(fisrtNumber, secondNumber, "+", (fisrtNumber + secondNumber));



}

static void FunctionSub()
{
    Console.Clear();
    CalculatorTitle();
    Console.WriteLine("#         Subtração Selecionado          #");
    CalculatorFisrtNumber();
    double fisrtNumber = double.Parse(Console.ReadLine());
    CalculatorSecondNumber();
    double secondNumber = double.Parse(Console.ReadLine());

    CalculatorResult(fisrtNumber, secondNumber, "-", (fisrtNumber - secondNumber));

}

static void FunctionMult()
{
    Console.Clear();
    CalculatorTitle();
    Console.WriteLine("#       Multiplicação Selecionado        #");
    CalculatorFisrtNumber();
    double fisrtNumber = double.Parse(Console.ReadLine());
    CalculatorSecondNumber();
    double secondNumber = double.Parse(Console.ReadLine());
    CalculatorResult(fisrtNumber, secondNumber, "*", (fisrtNumber * secondNumber));

}
static void FunctionDiv()
{
    Console.Clear();
    CalculatorTitle();

    Console.WriteLine("#         Divisão Selecionado            #");

    CalculatorFisrtNumber();
    double fisrtNumber = double.Parse(Console.ReadLine());

    CalculatorSecondNumber();
    double secondNumber = double.Parse(Console.ReadLine());
    CalculatorResult(fisrtNumber, secondNumber, "/", (fisrtNumber / secondNumber));

}
static void SelectFunction(string option)
{

    switch (option)
    {
        case "1": FunctionSum(); break;
        case "2": FunctionSub(); break;
        case "3": FunctionMult(); break;
        case "4": FunctionDiv(); break;
        case "9":
            {
                Console.Clear();
                Environment.Exit(0); break;
            }
        default:
            {
                Console.WriteLine("Funcao Invalida pressione uma tecla");
                Console.Read();
                StartAplication();
                break;
            }


    }
    Console.WriteLine("# Pressione uma tecla para voltar");
    Console.Read();
    StartAplication();

}

static void CalculatorTitle()
{
    Console.WriteLine("##########################################");
    Console.WriteLine("#            Calculadora em C#           #");
    Console.WriteLine("#                                        #");
    Console.WriteLine("##       Escolha a Opção desejada       ##");
    Console.WriteLine("##########################################");
    Console.WriteLine("# Soma      - 1      Multiplicação - 3   #");
    Console.WriteLine("# Subtração - 2      Divisão       - 4   #");
    Console.WriteLine("#                    Sair          - 9   #");
    Console.WriteLine("##########################################");
    return;
}

static void CalculatorFisrtNumber()
{
    Console.WriteLine("#        Digite o Primeiro numero        #");
    Console.WriteLine("##########################################");


}


static void CalculatorSecondNumber()
{

    Console.WriteLine("#                                        #");
    Console.WriteLine("#        Digite o Segundo numero         #");
    Console.WriteLine("##########################################");


}

static void CalculatorResult(double fisrtNumber, double secondNumber, string signal, double result)
{

    Console.WriteLine("#                                        #");
    Console.WriteLine("#        O Resultado da Operação é:      #");
    Console.WriteLine("#        " + fisrtNumber + " " + signal + " " + secondNumber + " = " + result);
    Console.WriteLine("##########################################");


}

