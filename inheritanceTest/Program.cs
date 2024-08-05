using System;

class Robot {
    public void move() {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot : Robot{ // CleanRobot이 Robot을 상속받음
    public void move() {
        Console.WriteLine("청소 로봇이 움직입니다.");

    }
}

class RescueRobot : Robot{ // RescueRobot이 Robot을 상속받음
    public void move()
    {
        Console.WriteLine("구조 로봇이 움직입니다.");

    }
}


class Program {
        public static void Main(string[] args){
            CleanRobot cr = new CleanRobot();
            RescueRobot rr = new RescueRobot();
            cr.move();
            rr.move();
            Console.ReadLine();
        }
    }