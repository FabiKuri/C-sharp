using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class Player
    {
        public string name;
        public int hp;

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        public void Defence()
        {
            Console.WriteLine(this.name + "は防御した");
            
        }
    }
}
