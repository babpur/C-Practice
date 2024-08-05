// 형 변환 -> 데이터의 형식을 변경해 데이터를 담는 과정
// 크기가 작은 자료형에서 큰 자료형으로 형 변환 시에 문제가 없지만 
// 큰 자료형에서 작은 자료형으로 강제 형 변환을 하게 되면 손실 등의 문제가 있음. --> Overflow 

//sbyte num = 128; // 불가능
//Console.WriteLine(num);

sbyte value1 = 64;
sbyte value2 = 64;
int value3 = value1 + value2; // 암시적 형 변환
// int value3 = (int) (value1 + value2) // 명시적 형 변환

Console.WriteLine(value3);

Console.WriteLine("종료하려면 아무 키나 누르세요");
Console.ReadLine();