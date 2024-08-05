// 반복문
// for or while
// for: 반복할 횟수를 알고 있을 때 사용
// while: 반복할 횟수를 모를 때 사용


// for(초기화 - 반복할 변수를 선언; 조건식 - 참인 경우 반복할 코드를 실행; 반복식 - 증감연산자) { 반복 코드 구현 }

/*
    1) 초기화
    2) 조건식
    3) 반복 코드
    4) 반복식의 순서로 실행됨.
 */

// ex1
// int i가 1부터 시작할 때, i가 11보다 작을 때까지 i를 출력, i가 1씩 증가.

for(int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("--------------------");

// while
// while (조건식) { 반복될 코드 }

// int j가 1이고 j가 11보다 작을 때까지 j를 출력 
int j = 1;
while (j < 11)
{
    Console.WriteLine(j);
    j++; // 증가식

}

Console.WriteLine("--------------------");

// 반복문 내에 조건문을 사용하여 프로그램 종료시키기.
while(true)
{
    Console.WriteLine(j);
    j++;

    if (j > 10)
    {
        break; // j가 10보다 크다면 종료하기.
    }
}


Console.WriteLine("프로그램을 종료하려면 아무 키나 누르세요");
Console.ReadLine();
