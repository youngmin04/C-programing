using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class RPG
    {
        struct Player
        {
            public int level;
            public int hp;
            public int fullhp;
            public int attack;
            public int defense;
            public int fullexp;
            public int exp;
            public int coin;
            public int evasion;
        }
        struct Monster
        {
            public string name;
            public int hp;
            public int fullhp;
            public int minattack;
            public int maxattack;
            public int exp;
            public int coin;
        }
        struct Playerstat
        {
            public int statpoint;
            public int power;//힘 1당 공격력 5증가
            public int health;//체력 1당 hp 10증가
            public int agility;//민첩 1당 도망칠 확률,회피율 1%증가;
        }
        static Random random = new Random();
        static void Stauts(ref Playerstat playerstat)
        {
            WriteLine($"힘 : {playerstat.power}");
            WriteLine($"민첩 : {playerstat.agility}");
            WriteLine($"체력 : {playerstat.health}");
            WriteLine($"잔여 포인트 : {playerstat.statpoint}");

            WriteLine("[1]포인트 분배하기");
            WriteLine("[2]나가기");

            int input = int.Parse(ReadLine());
            if (input==1)
            {
                WriteLine("스탯을 분배해주세요");
                while (true)
                {
                    WriteLine("[1]힘");
                    WriteLine("[2]민첩");
                    WriteLine("[3]체력");
                    WriteLine("[4]나가기");

                    int choice = int.Parse(ReadLine());
                    if (choice == 1)
                    {
                        WriteLine("얼마나 투자하시겠습니까?");
                        int stat = int.Parse(ReadLine());
                        if (playerstat.statpoint >= stat)
                        {
                            WriteLine($"힘 스탯에 {stat} 만큼 배분하셨습니다.");
                            playerstat.statpoint -= stat;
                            playerstat.power += stat;
                        }
                        else
                        {
                            WriteLine("잔여 포인트가 부족합니다.");
                        }
                    }
                    else if (choice == 2)
                    {
                        WriteLine("얼마나 투자하시겠습니까?");
                        int stat = int.Parse(ReadLine());
                        if (playerstat.statpoint >= stat)
                        {
                            WriteLine($"민첩 스탯에 {stat} 만큼 배분하셨습니다.");
                            playerstat.statpoint -= stat;
                            playerstat.agility += stat;
                        }
                        else
                        {
                            WriteLine("잔여 포인트가 부족합니다.");
                        }
                    }
                    else if (choice == 3)
                    {
                        WriteLine("얼마나 투자하시겠습니까?");
                        int stat = int.Parse(ReadLine());
                        if (playerstat.statpoint >= stat)
                        {
                            WriteLine($"체력 스탯에 {stat} 만큼 배분하셨습니다.");
                            playerstat.statpoint -= stat;
                            playerstat.health += stat;
                        }
                        else
                        {
                            WriteLine("잔여 포인트가 부족합니다.");
                        }
                    }
                    else if (choice == 4)
                    {
                        break; 
                    }
                }
            }
        }
        static void LevelUp(ref Playerstat playerstat,ref Player player)
        {
            if (player.exp >= player.fullexp)
            {
                WriteLine($"레벨 업! ({player.level}->{player.level + 1})");
                player.level += 1;
                player.exp -= player.fullexp;
                playerstat.statpoint += 5;
                player.fullexp += 50;
            }
        }
        static void Fight(ref Playerstat playerstat,ref Player player,ref Monster monster)
        {
            int rand = random.Next(1, 101);
            int monsterdamge = random.Next(monster.minattack, monster.maxattack);
            int damge = random.Next(player.level, player.attack);

            monster.hp -= damge;
            WriteLine(damge + "만큼 데미지를 주었습니다.");

            if (rand <= player.evasion)
            {
                WriteLine("회피하였습니다.");
            }
            else
            {
                player.hp -= monsterdamge-player.defense/5;
                WriteLine(monsterdamge + " 만큼 데미지를 입었습니다.");
            }
            if (monster.hp <= 0)
            {
                WriteLine("승리하였습니다! " + monster.exp + " 경험치 획득!");
                WriteLine($"{monster.coin} coin 획득!");
                player.exp += monster.exp;
                player.coin += monster.coin;
                LevelUp(ref playerstat, ref player);
            }
            if (player.hp <= 0)
            {
                WriteLine("사망하였습니다. (경험치가 하락합니다)");
                player.exp -= player.exp / 20;
                player.hp = 0;
            }
        }
        static void Information(ref Playerstat playerstat,ref Monster monster,ref Player player)
        {
            while (true)
            {
                WriteLine(monster.name);
                WriteLine("HP : " + monster.hp + "/" + monster.fullhp);
                WriteLine("ATK : " + monster.maxattack+"\n");

                WriteLine("Lv" + player.level);
                WriteLine("exp : " + player.exp + "/" + player.fullexp);
                WriteLine("HP : " + player.hp + "/" + player.fullhp);
                WriteLine("ATK : " + player.attack);
                WriteLine("DPS : " + player.defense+"\n");

                WriteLine("[1]전투");
                WriteLine("[2]도망\n");

                int choice = int.Parse(ReadLine());
                if (choice == 1)
                {
                    Fight(ref playerstat,ref player, ref monster);
                    if (monster.hp <= 0||player.hp<=0)
                    {
                        break;
                    }
                }
                else if (choice == 2)
                {
                    int rand = random.Next(1, 101);
                    if (rand <= 33)
                    {
                        WriteLine("무사히 도망쳤습니다.");
                        break;
                    }
                    else
                    {
                        WriteLine("도망치지 못했습니다.");
                    }
                }
            }
        }
        static void CreateMonster(ref Playerstat playerstat,ref Player player,out Monster monster,ref int input)
        {
            while (true)
            {
                int rand = random.Next(1, 4);
                if (input == 1)
                {
                    switch (rand)
                    {
                        case 1:
                            monster.name = "슬라임";
                            monster.hp = 10;
                            monster.fullhp = 10;
                            monster.minattack = 3;
                            monster.maxattack = 9;
                            monster.exp = 25;
                            monster.coin = 3;
                            break;
                        case 2:
                            monster.name = "트롤";
                            monster.hp = 17;
                            monster.fullhp = 17;
                            monster.minattack = 5;
                            monster.maxattack = 11;
                            monster.exp = 35;
                            monster.coin = 5;
                            break;
                        case 3:
                            monster.name = "호블린";
                            monster.hp = 20;
                            monster.fullhp = 20;
                            monster.minattack = 7;
                            monster.maxattack = 15;
                            monster.exp = 40;
                            monster.coin = 10;
                            break;
                        default:
                            monster.name = "없음";
                            monster.hp = 0;
                            monster.fullhp = 0;
                            monster.minattack = 0;
                            monster.maxattack = 0;
                            monster.exp = 0;
                            monster.coin = 0;
                            break;
                    }
                    WriteLine(monster.name + "이 나타났다!\n");
                    Information(ref playerstat, ref monster, ref player);
                    break;
                }
                else if (input == 2)
                {
                    switch(rand)
                    {
                        case 1:
                            monster.name = "고블린 병사";
                            monster.hp = 23;
                            monster.fullhp = 23;
                            monster.minattack = 9;
                            monster.maxattack = 16;
                            monster.exp = 45;
                            monster.coin = 13;
                            break;
                        case 2:
                            monster.name = "고블린 창병";
                            monster.hp = 28;
                            monster.fullhp = 28;
                            monster.minattack = 11;
                            monster.maxattack = 18;
                            monster.exp = 50;
                            monster.coin = 15;
                            break;
                        case 3:
                            monster.name = "홉 고블린";
                            monster.hp = 35;
                            monster.fullhp = 35;
                            monster.minattack = 13;
                            monster.maxattack = 22;
                            monster.exp = 70;
                            monster.coin = 20;
                            break;
                        default:
                            monster.name = "없음";
                            monster.hp = 0;
                            monster.fullhp = 0;
                            monster.minattack = 0;
                            monster.maxattack = 0;
                            monster.exp = 0;
                            monster.coin = 0;
                            break;
                    }
                    WriteLine(monster.name + "이 나타났다!\n");
                    Information(ref playerstat, ref monster, ref player);
                    break;
                }
                else if (input == 3)
                {

                }
                else if (input == 4)
                {

                }
                else if (input == 5)
                {

                }
                else if (input == 6)
                {

                }
                else if (input == 7)
                {

                }
            }

        }
        static void FieldChoice(ref Playerstat playerstat,ref Player player)
        {
            while (true)
            {
                WriteLine("[1]튜토리얼의 마을");
                WriteLine("[2]고블린의 주거지");
                WriteLine("[3]저주의 숲");
                WriteLine("[4]리저드맨의 늪");
                WriteLine("[5]심연의 바다");
                WriteLine("[6]언데드의 성");
                WriteLine("[7]지옥의 유적");

                int input = int.Parse(ReadLine());

                Monster monster;
                CreateMonster(ref playerstat,ref player,out monster,ref input);
                break;
            }
        }
        static void Rest(ref Player player)
        {
            while (true)
            {
                WriteLine("여관에 입장하였습니다.(5coin 지불)");
                WriteLine("Coin" + player.coin);
                WriteLine("[1]휴식");
                WriteLine("[2]나가기");
                int choice = int.Parse(ReadLine());
                if (choice == 1)
                {
                    if (player.coin >= 5)
                    {
                        player.hp = player.fullhp;
                        player.coin -= 10;
                        WriteLine("휴식 취하였습니다. hp가 회복됩니다.");
                        break;
                    }
                    else
                    {
                        WriteLine("소지금이 부족합니다.");
                        break;
                    }
                }
                else if (choice == 2)
                {
                    WriteLine("여관에서 나왔습니다.");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            WriteLine("게임을 시작하시겠습니까?(Y/N)");
            string choice = ReadLine();

            if (choice == "Y" || choice == "y")
            {
                Player player;

                Playerstat playerstat;

                playerstat.power = 5;
                playerstat.agility = 3;
                playerstat.health = 10;
                playerstat.statpoint = 0;

                player.level = 1;
                player.exp = 0;
                player.fullexp = 100;
                player.coin = 0;
                player.hp = playerstat.health * 10;

                while (true)
                {
                    player.fullhp = playerstat.health * 10;
                    player.attack = playerstat.power * 2;
                    player.defense = playerstat.health * 1;
                    player.evasion = playerstat.agility;

                    WriteLine("Lv" + player.level + " exp " + player.exp + "/" + player.fullexp);
                    WriteLine("HP : " + player.hp + "/" + player.fullhp);
                    WriteLine("ATK : " + player.attack);
                    WriteLine("DPS : " + player.defense);
                    WriteLine("Coin : " + player.coin);

                    WriteLine("[1]스테이터스");
                    WriteLine("[2]인벤토리");
                    WriteLine("[3]필드");
                    WriteLine("[4]상점");
                    WriteLine("[5]여관");

                    int choice1 = int.Parse(ReadLine());

                    if (choice1 == 1)
                    {
                        Stauts(ref playerstat);
                    }
                    else if (choice1 == 3)
                    {
                        FieldChoice(ref playerstat,ref player);
                    }
                    else if (choice1 == 5)
                    {
                        Rest(ref player);
                    }
                }
            }
            else if (choice == "N" || choice == "n")
            {
                WriteLine("게임을 플레이하지 않았습니다.");
                return;
            }
            else
            {
                WriteLine("이상한 문자가 입력되었습니다. 종료합니다.");
                return;
            }
        }
    }
}
