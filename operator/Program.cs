// 산술연산자 : +, -, *, /, %

// +
int result = 3 + 1;
Console.WriteLine(result);

// -
result = 3 - 1;
Console.WriteLine(result);

int num1 = 2;

// * --> result * num1
result = 5 * num1;
Console.WriteLine(result);

// / 
int num2 = 10;
result = num2 / 3;
Console.WriteLine(result);

// %
result = 10 & 2;
Console.WriteLine(result);


Console.WriteLine("--------------------");

// 증감연산자 : ++, --
int num = 0;
Console.WriteLine(num++); // 0
Console.WriteLine(num); // 1
Console.WriteLine(--num); // 0
Console.WriteLine(num); // 0

Console.WriteLine("--------------------");

// 관계연산자 : >, <, >=, <=, ==, != --> 값의 크고 작음, 같고 다름을 비교하기 위한 연산자

bool resultBool = false;

int resultNum1 = 3;
int resultNum2 = 5;

resultBool = resultNum1 > resultNum2; // F
Console.WriteLine(resultBool);

resultBool = resultNum1 < resultNum2; // T
Console.WriteLine(resultBool);

resultBool = resultNum1 >= resultNum2; // F
Console.WriteLine(resultBool);

resultBool = resultNum1 <= resultNum2; // T
Console.WriteLine(resultBool);

resultBool = resultNum1 == resultNum2; // F
Console.WriteLine(resultBool);

resultBool = resultNum1 != resultNum2; // T
Console.WriteLine(resultBool);


Console.WriteLine("--------------------");

// 논리연산자 : 논리합(OR) - 둘 중 하나가 참일 경우는 참, 논리곱(AND) - 둘 다 참일 경우 참, 부정(NOT)을 이용해 참과 거짓을 표현하는 연산자

bool a = true;
bool b = false;

// 논리합
Console.WriteLine(a && a); // T
Console.WriteLine(a && b); // F

// 논리곱
Console.WriteLine(a || b); // T
Console.WriteLine(b || b); // F

// 부정
Console.WriteLine(!a); // F
Console.WriteLine(!b); // T

Console.WriteLine("아무 키나 입력하면 프로그램이 종료됩니다.");
Console.ReadLine();
