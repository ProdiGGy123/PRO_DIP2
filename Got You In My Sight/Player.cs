using System;

namespace Player
{
    public class Player
    {
        protected int HP = 100;

        public string Weapon = "Buster Claw";

        public void BusterAtkStat()
        {
            if(Weapon == "Buster Claw")
            {
                AttackStat = 35;
            }
        }
    }
}