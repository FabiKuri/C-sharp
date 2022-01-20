using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class Player
    {
        private string name;
        private int hp;

        public Player(string name, int hp)
        {
            this.name  = name;
            this.hp = hp;
        }

        

        public void SetName(string name)
        {  
            if  (name  != null)
            {
                int len =  name.Length;

                if (len <= 8)
                {
                    this.name = name;
                }
            }
        }
        public string GetName()
        {
            return this.name;
        }



        public void SetHp(int hp)
        {
            this.hp = hp;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }

        public int GetHp()
        {
            return this.hp;
        }

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        public void Defence()
        {
            Console.WriteLine(this.name + "は防御した");
            
        }
    }

    // class Enemy
    // {
    //     public int hp;

    //     public void Attack()
    //     {
    //         Console.WriteLine("敵の攻撃");
    //     }

    //     public void Runaway()
    //     {
    //         Console.WriteLine("逃げられた");
    //     }
    // }
}
