int num = 10;

if (num == 10)
{
    Console.WriteLine("입력한 숫자는 10입니다.");
}
else if (num == 9)
{
    Console.WriteLine("입력한 숫자는 9입니다.");
}
else
{
    Console.WriteLine("입력한 숫자는 10 또는 9가 아닙니다.");
}

if (num > 0)
{
    Console.WriteLine("양수입니다.");
}
else if (num < 0)
{
    Console.WriteLine("음수입니다.");
}
else
{
    Console.WriteLine("0입니다.");
}

Console.WriteLine("프로그램을 종료하려면 엔터 키를 누르세요.");
Console.ReadLine();