using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    public enum Gamemode2
    {
        None,
        Lobby,
        Town,
        Field,
        Shop,
        Sleep
    }
    class Game2
    {
        private Gamemode2 mode = Gamemode2.Lobby;
        private Player2 player = null;
        private Monster2 monster = null;
        private Random rand = new Random();

        public void Process()
        {
            switch (mode)
            {
                case Gamemode2.Lobby:
                    ProcessLobby();
                    break;
                case Gamemode2.Town:
                    ProcessTown();
                    break;
                case Gamemode2.Field:
                    ProcessField();
                    break;
                case Gamemode2.Shop:
                    ProcessShop();
                    break;
                case Gamemode2.Sleep:
                    ProcessSleep();
                    break;
            }
        }
        public void ProcessLobby()
        {
            WriteLine("당신의 키를 선택하세요!");
            WriteLine("[1]작은 키");
            WriteLine("[2]큰 키");
            WriteLine("[3]평균 키");
            
            string input = ReadLine();
            switch (input)
            {
                case "1":
                    player = new Shortheight();
                    mode = Gamemode2.Town;
                    break;
                case "2":
                    player = new Longheight();
                    mode = Gamemode2.Town;
                    break;
                case "3":
                    player = new Nowheight();
                    mode = Gamemode2.Town;
                    break;
            }
        }
        public void ProcessTown()
        {
            WriteLine($"HP : {player.hp}");
            WriteLine($"Attack : {player.attack}");
            WriteLine($"Coin : {player.coin}");
            WriteLine("마을에 입장하였습니다.");
            WriteLine("[1] 식탁으로 가기");
            WriteLine("[2] 냉장고를 열기");
            WriteLine("[3] 잠자기");
            WriteLine("[4] 키 선택창으로 돌아가기");

            string input = ReadLine();
            switch (input)
            {
                case "1":
                    mode = Gamemode2.Field;
                    break;
                case "2":
                    mode = Gamemode2.Shop;
                    break;
                case "3":
                    mode = Gamemode2.Sleep;
                    break;
                case "4":
                    mode = Gamemode2.Lobby;
                    break;
            }
        }
        public void ProcessField()
        {
            WriteLine("식탁에 앉았습니다.");
            WriteLine("[1] 식탁에서 치운다");
            WriteLine("[2] 방으로 돌아간다");

            CreateRandomMonster();

            string input = ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
        }
        //상점 시스템
        public void ProcessShop()
        {
            WriteLine("[1] 우유 (75 coin)");
            WriteLine("[2] 멸치볶음 (45 coin)");
            WriteLine("[3] 검은 콩볶음 (60 coin)");

            int input = int.Parse(ReadLine());
            if (input == 1)
            {
                if (player.coin < 75)
                {
                    WriteLine("구매하실 수 없습니다.");
                    ProcessTown();
                }
                else
                {
                    player.attack += 5;
                    player.coin -= 5;
                    ProcessTown();
                }
            }
            else if (input == 2)
            {
                if (player.coin < 45)
                {
                    WriteLine("구매하실 수 없습니다.");
                    ProcessTown();
                }
                else
                {
                    player.fullhp += 10;
                    player.coin -= 10;
                    ProcessTown();
                }
            }
            else if (input == 3)
            {
                if (player.coin < 60)
                {
                    WriteLine("구매하실 수 없습니다.");
                    ProcessTown();
                }
                else
                {
                    player.fullhp += 15;
                    player.coin -= 15;
                    ProcessTown();
                }
            }
        }
        //여관 시스템
        public void ProcessSleep()
        {
            WriteLine("잠을 청하시겠습니까?");
            WriteLine("[1]YES");
            WriteLine("[2]NO");

            int input = int.Parse(ReadLine());
            if (input == 1)
            {
                WriteLine("잠을 잡니다.");
                player.hp = player.fullhp;
                ProcessTown();
            }
            else if (input == 2)
            {
                WriteLine("잠을 청하지 않았습니다.");
                ProcessTown();
            }
            
        }
        public void TryEscape()
        {
            int randValue = rand.Next(0, 101);
            if (randValue < 33)
            {
                mode = Gamemode2.Town;
            }
            else
            {
                ProcessFight();
            }
        }
        public void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.Damage(damage);
                WriteLine($"{damage} 만큼 피해를 입혔습니다.");
                if (monster.Death())
                {
                    WriteLine("승리하였습니다!");
                    WriteLine($"남은 체력{player.GetHp()}");
                    player.coin += monster.coin;
                    WriteLine($"{monster.coin} coin을 획득하였습니다!");
                    break;
                }
                damage = monster.GetAttack();
                player.Damage(damage);
                WriteLine($"{damage} 만큼 피해를 입었습니다.");
                if (player.Death())
                {
                    WriteLine("패배하였습니다!");
                    mode = Gamemode2.Lobby;
                    break;
                }
            }
        }
        public void CreateRandomMonster()
        {
            int randValue = rand.Next(0, 3);
            switch (randValue)
            {
                case 0:
                    monster = new Ramen();
                    WriteLine("라면이 나타났다!");
                    break;
                case 1:
                    monster = new Noodle();
                    WriteLine("국수가 나타났다!");
                    break;
                case 2:
                    monster = new Cola();
                    WriteLine("콜라가 나타났다!");
                    break;
            }
        }
    }
}

