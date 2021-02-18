using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address0218
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                switch(getMenu())
                case 1:
                    Console.WriteLine("정보 추가");
                    break;
                case 2:
                    Console.WriteLine("정보 보기");
                    break;
                case 3:
                    Console.WriteLine("프로그램 종료");
                    Environment.Exit(0);
                    //=system.exit(0);
                    break;
            }
        }

        public static int getMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 관리 v1.0");
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 정보 추가");
            Console.WriteLine("주소록 정보 보기");
            Console.WriteLine("종료");
            Console.WriteLine("------------------");
            Console.Write("메뉴 선택");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }
    }
}
