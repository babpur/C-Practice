// 클래스와 인스턴스 --> 객체

// 클래스 : 설계도
// 인스턴스 : 설계도를 실체화


// 클래스 내의 정적인 성질 == attribute == property == 멤버 변수 
// ex) color, size 등

// 클래스 내의 동적인 성질 == method
// ex) moving, act 등등

/*
    using System; --> System은 class의 집합이며, namespace

    class MainClass {
        public static void Main (String[] args) {
            // 코드 영엽
        }
    } --> 클래스의 끝
 */

using System.Security.Cryptography;

class Person // 클래스의 첫 글자는 대문자로 선언
{
    // 속성 == property
    public string name;
    public string birthday;
    public string gender;


    // 메소드 : 클래스 내부에 선언
    public void eat()
    {
        // 먹다
        Console.WriteLine(name + "이/가 식사를 합니다.");
    }
    
    public void walk()
    {
        // 걷다
        Console.WriteLine(name + "이/가 걷습니다.");
    }

    public void run()
    {
        // 뛰다
        Console.WriteLine(name + "이/가 뜁니다.");
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Person p1 = new Person();
            p1.name = "서준";
            p1.eat();
            Console.ReadLine();
        }
    }
}


