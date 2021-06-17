using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class TextRPGproject1
    {
        enum ClassType
        {
            None=0,Knight=1,Archer=2,Mage=3,
        }
        struct Player
        {
            public int hp;
            public int attack;
            public int coin;
        }
        struct Monster
        {
            public string name;
            public int hp;
            public int attack;
            public int coin;
        }
        static void CreatePlayer(out Player player)
        {
            WriteLine("[1] 기사");
            WriteLine("[2] 궁수");
            WriteLine("[3] 마법사");

            int input = int.Parse(ReadLine());

            switch (input)
            {
                case 1:
                    player.hp = 100;
                    player.attack = 30;
                    player.coin = 10;
                    break;
                case 2:
                    player.hp = 120;
                    player.attack = 25;
                    player.coin = 25;
                    break;
                case 3:
                    player.hp = 80;
                    player.attack = 40;
                    player.coin = 20;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    player.coin = 0;
                    break;
            }
        }
        static void CreateMonster(out Monster monster)
        {
            Random random = new Random();
            int rand = random.Next(1, 4);

            switch (rand)
            {
                case 1:
                    monster.name = "슬라임";
                    monster.hp = 50;
                    monster.attack = 5;
                    monster.coin = 5;
                    break;
                case 2:
                    monster.name = "스켈레톤 나이트";
                    monster.hp = 80;
                    monster.attack = 20;
                    monster.coin = 10;
                    break;
                case 3:
                    monster.name = "아크 리치";
                    monster.hp = 50;
                    monster.attack = 30;
                    monster.coin = 45;
                    break;
                default:
                    monster.name = "없음";
                    monster.attack = 0;
                    monster.hp = 0;
                    monster.coin = 0;
                    break;
            }
        }
        
        static void MakeField(ref Player player)
        {
            WriteLine("[1]전투");
            WriteLine("[2]상점");
            WriteLine("[3]일정 확률로 도망");
            int input = int.Parse(ReadLine());

            Monster monster;
            CreateMonster(out monster);

            switch (input)
            {
                case 1:
                    Fight(ref player, ref monster);
                    break;
                case 2:
                    Run(ref player, ref monster);
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
                    WriteLine("승리하였습니다.");
                    break;
                }
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    WriteLine("패배하였습니다.");
                    break;
                }
            }
        }
        static void Run(ref Player player, ref Monster monster)
        {
            while (true)
            {
                Random random = new Random();
                int rand = random.Next(1, 101);
                if (rand <= 20)
                {
                    WriteLine("도망쳤습니다.");
                    break;
                }
                else
                {
                    Fight(ref player, ref monster);
                    break;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Player player;

            while (true)
            {
                CreatePlayer(out player);

                
                WriteLine("[1]필드 접속");
                WriteLine("[2]로비로 이동");

                int input = int.Parse(ReadLine());

                if (input == 1)
                {
                    MakeField(ref player);
                }
                else if (input == 2)
                {
                    return;
                }
                
            }
            
        }
    }
}
