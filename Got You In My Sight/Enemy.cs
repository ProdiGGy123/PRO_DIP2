using System;

namespace Enemy
{
    class Enemy
    {
       protected string Weapon = "Magnum";

       public void MagnumAtkStat()
       {
           if(Weapon == "Magnum")
           {
               LightAttackStat = 3;
           }
       }

       public void MagnumMAtkStat()
       {
           if(Weapon == "Magnum")
           {
               MediumAttackStat = 5;
           }
       }

       public void MagnumHAtkStat()
       {
           if(Weapon == "Magnum")
           {
               HeavyAttackStat = 10;
           }
       }

       
    
    }
}