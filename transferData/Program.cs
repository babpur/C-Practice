using System;


namespace transferData {
    
    class Cat
    {
        //public string name; --> 모두 접근 가능
        private string name;

        public void setName(string name) // set은 반환값이 없기 때문에 void
        {
            this.name = name; // 좌변의 this.name은 자기 자신, 우변의 name은 입력받은 값.  
        }

        public string getName()
        {
            return this.name; // 멤버 변수에 접근하기 위해 this 사용
        }


        public Cat(string name){
            this.name = name; // 매개 변수를 이용하여 이름 선언
            Console.WriteLine("고양이의 이름은 " + name + "입니다.");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("코코");
            // myCat.name = "몰리"; // 멤버 변수의 이름을 몰리로 선언
            //Console.WriteLine("고양이의 이름은 " + myCat.name + "입니다.");
            // ㄴ 정보 은닉의 특징으로 직접 접근할 수 없음.

            myCat.setName("몰리");
            Console.WriteLine("고양이의 이름은 " + myCat.getName() + "입니다.");

            Console.ReadLine();
        }
    }
}
