﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월을 입력하세요 : ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 3: case 4: case 5:
                    Console.WriteLine("봄");break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름"); break;
                case 9: case 10: case 11:
                    Console.WriteLine("가을"); break;
                case 12: case 1: case 2:
                    Console.WriteLine("겨울"); break;
                default:
                    Console.WriteLine("잘못 입력했습니다");
                    break;
            }
        }
    }
}
