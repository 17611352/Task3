using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Wizard_Unit : Unit
    {
        public Wizard_Unit(int xpos, int ypos, int health, int speed, int attack, int attackRange, string symbol, string team)
        {
            Xpos = xpos;
            Ypos = ypos;
            Health = health;
            base.maxHealth = health;
            Speed = speed;
            Attack = attack;
            AttackRange = attackRange;
            Symbol = symbol;
            Team = team;
        }

        public int Xpos
        {
            get { return base.xPos; }
            set { base.xPos = value; }
        }

        public int Ypos
        {
            get { return base.yPos; }
            set { yPos = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        public int MaxHealth
        {
            get { return base.maxHealth; }
        }

        public int Speed
        {
            get { return base.speed; }
            set { base.speed = value; }
        }

        public int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }

        public int AttackRange
        {
            get { return base.attackRange; }
            set { base.attackRange = value; }
        }

        public string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }

        public string Team
        {
            get { return base.team; }
            set { base.team = value; }
        }

        public bool IsAttacking
        {
            get { return base.isAttacking; }
            set { isAttacking = value; }
        }

        public bool IsDead { get; set; }




        public override (Unit, int) ClosestUnit(List<Unit> units)
        {
            int shortest = 100;
            Unit closest = this;
            //Closest Unit and Distance                    
            foreach (Unit u in units)
            {
                if (u is Melee_Unit)
                {
                    Melee_Unit otherMu = (Melee_Unit)u;
                    int distance = Math.Abs(this.Xpos - otherMu.Xpos)
                               + Math.Abs(this.Ypos - otherMu.Ypos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherMu;
                    }
                }
                else if (u is Ranged_Unit)
                {
                    Ranged_Unit otherRu = (Ranged_Unit)u;
                    int distance = Math.Abs(this.Xpos - otherRu.Xpos)
                               + Math.Abs(this.Ypos - otherRu.Ypos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherRu;
                    }
                }

            }
            return (closest, shortest);
        }

        public override void Combat(Unit attacker)
        {
            if (attacker is Melee_Unit)
            {
                Health = Health - ((Melee_Unit)attacker).Attack;
            }
            else if (attacker is Ranged_Unit)
            {
                Ranged_Unit ru = (Ranged_Unit)attacker;
                Health = Health - (ru.Attack - ru.AttackRange);
            }

            if (Health <= 0)
            {
                Death(); //DEATH !!!
            }
        }

        public override void Death()
        {
            symbol = "X";
            isDead = true;
        }

        public override void Move(int dir)
        {
            switch (dir)
            {
                case 0: Ypos--; break; //North
                case 1: Xpos++; break; //East
                case 2: Ypos++; break; //South
                case 3: Xpos--; break; //West
                default: break;
            }
        }

        public override bool Range(Unit other)
        {
            int distance = 0;
            int otherX = 0;
            int otherY = 0;
            if (other is Melee_Unit)
            {
                otherX = ((Melee_Unit)other).Xpos;
                otherY = ((Melee_Unit)other).Ypos;
            }
            else if (other is Ranged_Unit)
            {
                otherX = ((Ranged_Unit)other).Xpos;
                otherY = ((Ranged_Unit)other).Ypos;
            }

            distance = Math.Abs(Xpos - otherX) + Math.Abs(Ypos - otherY);
            if (distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
