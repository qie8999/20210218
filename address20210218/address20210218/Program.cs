using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address20210218
{
    class Program
    {
        //C#은  const 자바는 final
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RAMDOM_ADD = 3;
        const int MENU_DELE = 4;
        const int MENU_DELE_ALL = 5;
        const int MENU_EXIT = 6;


        static List<Student> addrList = new List<Student>();
        //배열으로 생각할것, 사이즈 정해지지 않은 공간
        /*static Student stud; 싱글톤*/
        static void Main(string[] args)
        {
            

            /*stud = Student.getInst(); 싱글톤 Student에서 가져옴*/
            /*Student st = null;*/
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        addItem();
                        break;
                    case MENU_VIEW:
                        viewItem();
                        break;
                    case MENU_RAMDOM_ADD:
                        randData();
                        break;
                    case MENU_DELE:
                        delItem();
                        break;
                    case MENU_DELE_ALL:
                        delItemAll();
                        break;
                    case MENU_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        //=system.exit(0)
                        break;
                }
                }
            }
        public static void addItem()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("------------------");           
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화 : ");
            string tel = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();
            Console.Write("이메일 : ");
            string email = Console.ReadLine();

            addrList.Add(new Student(name, tel, address, email));
            //객체 생성해서 집어넣는다

            /*return new Student(name, tel, address, email);*/
            /*=Student st = new Student(name, tel, address, email);
            return st;*/

        }
        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호 : " + (i+1));
                Console.WriteLine("이름 : " +addrList[i].Name);
                Console.WriteLine("전화 : " +addrList[i].Tel);
                Console.WriteLine("주소 : " + addrList[i].Address);
                Console.WriteLine("이메일 : " + addrList[i].Email);
                Console.WriteLine("---------------------------");

            }
        }

            public static int getMenu()
            {
                Console.WriteLine("------------------");
                Console.WriteLine("주소록 관리 v1.0");
                Console.WriteLine("------------------");
                Console.WriteLine("1.주소록 정보 추가");
                Console.WriteLine("2.주소록 정보 보기");
                Console.WriteLine("3.랜덤데이터 추가");
                Console.WriteLine("4.주소록 정보 삭제");
                Console.WriteLine("5.정보 전체 삭제");
                Console.WriteLine("6.종료");
                Console.WriteLine("------------------");
                Console.Write("메뉴 선택");
                int menu = Convert.ToInt32(Console.ReadLine());
                           //=int.parse(Console.ReadLine());
            return menu;
            }
        public static void randData()
        {
            string[] rName = { "홍길동", "김길동", "이길동", "박길동", "오길동" };
            string[] rTel = { "010-1111-2222", "011-333-4444", "017-555-6666", "018-7878-5454", "053-5252-2121" };
            string[] rAddress = { "대구시 동구 신암4동", "서울시 동구 신암4동",
                "부산시 동구 신암4동", "안동시 동구 신암4동", "광주시 동구 신암4동" };
            string[] rEmail = { "r@gmail.com", "d@gmail.com", "k@gmail.com", "g@gmail.com", "s@gmail.com" };
            Random r = new Random();
            for (int i = 0; i < 10; i++){
               
                addrList.Add(new Student(
                    rName[r.Next(0, 5)],
                    rTel[r.Next(0, 5)],
                    rAddress[r.Next(0, 5)],
                    rEmail[r.Next(0, 5)]));
               
            }

        }
        static void delItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("-----------------");            
            Console.WriteLine("삭제할 이름을 입력하세요");
            string name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Name == name) {

                    /*addrList.RemoveAt(i);
                    i--;*/
                    addrList.RemoveAt(i--);

                }

            }
            
        }
        static void delItemAll()
        {
            addrList.Clear();
        }

    }
}

