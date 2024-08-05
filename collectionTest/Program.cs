using System.Collections; // java의 import와 비슷한 개념

namespace collectionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 컬렉션 : 여러 데이터 형을 포함해 입/출력, 데이터 처리를 수행할 수 있는 자료 구조
            // ㄴ 데이터를 다루기 편리한 클래스의 집합.

            // ArrayList : Array는 크기가 정해져 있는 반면 ArrayList는 가변적, 순차적으로 값이 추가되는 것은 동일
            // 값의 형태 또한 여러 가지 유형으로 저장이 가능

            ArrayList al = new ArrayList();
            // item 입력 시 Add 메서드 사용
            al.Add(1);
            al.Add("Hello");
            al.Add(3.3);
            al.Add(true);
            // ㄴ 데이터 형이 다르더라도 ArrayList에 넣을 수 있음

            // 출력
            foreach(var item in al){
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Remove 메서드를 통해 아이템 삭제
            al.Remove("Hello");

            foreach (var item in al){
                Console.WriteLine(item);
            }

            // Queue : 선입선출 --> 먼저 입력한 것이 먼저 빠져나감.
            Queue qu = new Queue();

            // item 입력 시 Enqueue 메서드를 사용
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            // Dequeue 메서드를 이용하여 item 제거
            while (qu.Count > 0) { // qu의 count 개수가 0보다 클 때 출력하겠다.
                Console.WriteLine(qu.Dequeue());
            }

            // Stack : 선입후출 --> 먼저 입력된 값이 나중에 나감

            Stack st = new Stack();
            
            // push을 이용해 item 추가
            st.Push(1);
            st.Push(2); 
            st.Push(3);

            // pop을 이용해 item 제거
            while (st.Count > 0){
                Console.WriteLine(st.Pop);
            }

            // Hashtable : 순서 x --> key-value
            Hashtable ht = new Hashtable();
            ht["apple"] = "사과";
            ht["banana"] = "바나나";
            ht["orange"] = "오렌지";

            Console.WriteLine("apple");
            Console.WriteLine("banana");
            Console.WriteLine("orange");

            Console.ReadLine();
        }
    }
}
