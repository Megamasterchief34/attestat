void Main()
{
    int N = Readint("Введите первое число : ");
    int M = Readint("Введите второе число : ");
    PrintNumbers (N,M);

}

void PrintNumbers(int N, int M)
{
    
    if(N > M) return;
    System.Console.Write(N + " ");
    PrintNumbers(N+1,M);
    
    
}

int Readint(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();

