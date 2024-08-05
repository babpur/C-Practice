using System;

class Cat{
    public string name;
    public int weight;

    public Cat(string name){ // 생성자
        Console.WriteLine("고양이의 이름은 " + name + "입니다.");
    }

    // 소멸자 : 인스턴스 변수가 사라질 때 호출됨.
    // .net
    ~Cat(){
        Console.WriteLine(name + "이/가 사라집니다.");
    }


    // 메서드 오버로딩(Overloading)
    public Cat(string name, int weight){
        Console.WriteLine("고양이의 이름은 " + name + ", 몸무게는 " + weight + "kg입니다.");
    }

}

class MainClass{
    public static void Main(String[] args){
        Cat myCat1 = new Cat("코코"); 
        Cat myCat2 = new Cat("몰리", 5);
        Console.ReadLine();
    }
}