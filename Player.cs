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
