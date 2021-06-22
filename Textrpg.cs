using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Programing
{
    class Textrpg
    {
        enum ClassType
        {
            None=0, shortheight=1,longheight=2,Nowheight=3
        }
        struct Player
        {
            public int hp;
            public int attack;
        }
        enum MonsterType
        {
            None=0,Milk=1,Anchovies = 2, bean = 3
        }
        struct Monster
        {
            public int hp;
            public int attack;
        }
        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;
            WriteLine("직업을 선택해 주세요.");
            WriteLine("[1]작은 키");
            WriteLine("[2]큰 키");
            WriteLine("[3]지금 키");
            
            string input = ReadLine();
            
            switch (input)
            {
                case "1":
                    choice = ClassType.shortheight;
                    break;
                case "2":
                    choice = ClassType.longheight;
                    break;
                case "3":
                    choice = ClassType.Nowheight;
                    break;
            }
            return choice;
        }
        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch (choice)
            {
                case ClassType.shortheight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.longheight:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Nowheight:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }
        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch (randMonster)
            {
                case (int)MonsterType.Milk:
                    WriteLine("우유를 발견하였다.");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Anchovies:
                    WriteLine("멸치를 발견하였다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.bean:
                    WriteLine("콩을 발견하였다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }
        static void Fight(ref Player player,ref Monster monster)
        {
            while (true)
            {
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    WriteLine("키가 커집니다.");
                    WriteLine($"남은 체력은 {player.hp}");
                    break;
                }
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    WriteLine("키가 줄어듭니다.");
                    break;
                }
            }
        }
        static void EnterField(ref Player player)
        {
            while (true)
            {
                WriteLine("당신의 뼈에 접속하였습니다!");
                //몬스터 생성하기
                Monster monster;
                CreateRandomMonster(out monster);
                WriteLine("[1] 먹는다.");
                WriteLine("[2] 먹지 않는다.");

                string input = ReadLine();
                if (input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 33)
                    {
                        WriteLine("키를 유지하는데 성공했습니다!");
                        break;
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }
            }
            
        }
        static void EnterGame(ref Player player)
        {
            while (true)
            {
                WriteLine("식탁에 앉았습니다");
                WriteLine("[1] 키를 키운다");
                WriteLine("[2] 그대로 돌아간다");

                string input = ReadLine();
                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        break ;
                    case "2":
                        return;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    Player player;

                    CreatePlayer(choice,out player);

                    EnterGame(ref player);

                    //WriteLine($"HP{player.hp},Attack{player.attack}");
                    
                }
            }
        }
    }
}
