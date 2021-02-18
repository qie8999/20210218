using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addrTest0218_1
{
    class Program
    {
        static List<Student> addrList= new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                switch(getMenu())
                {
                    case 1:
                        addItem();
                        break;
                    case 2:
                        viewItem();
                        break;
                    case 5:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    

                }
            }

        }


        
        public static void addItem()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-------------------");
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화 : ");
            string tel = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();
            Console.Write("이메일 : ");
            string email = Console.ReadLine();

            addrList.Add(new Student(name, tel, address, email));

        }

        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호 : " + (i+1));
                Console.WriteLine("이름 : " + addrList[i].Name);
                Console.WriteLine("전화 : " + addrList[i].Tel);
                Console.WriteLine("주소 : " + addrList[i].Address);
                Console.WriteLine("이메일 : " + addrList[i].Email);
                Console.WriteLine("----------------------");

            }
        }

        public static int getMenu()
        {

            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 관리 v1.0");
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.종료");
            Console.WriteLine("-----------------");
            Console.Write("명령 입력 :");
            int menu = int.Parse(Console.ReadLine());

            return menu;
        }
    }
}

