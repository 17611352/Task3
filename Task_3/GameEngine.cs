using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public class GameEngine
    {
        Random r = new Random();
        GroupBox grpMap;

        Map map;
        //Form1 form = new Form1();
        public int check = 0;
        public int round = 0;

        public GameEngine(GroupBox gMap)
        {
            grpMap = gMap;
            map = new Map();           
            //map.GenerateUnits(5);
            //map.DisplayUnits(grpMap);
        }

        public int NumOfRound()
        {
            round++;
            return round;
        }

        public void UpdateMovement()
        {
            for (int i = 0; i < map.Units.Count; i++)
            {
                if (map.Units[i] is Melee_Unit)
                {
                    Melee_Unit mu = (Melee_Unit)map.Units[i];
                    if (mu.Health <= mu.MaxHealth * 0.25) // Running Away
                    {
                        mu.Move(r.Next(0, 4));
                    }
                    else
                    {
                        (Unit closest, int distanceTo) = mu.ClosestUnit(map.Units);

                        //Check In Range
                        if (distanceTo <= mu.AttackRange)
                        {
                            mu.IsAttacking = true;
                            mu.Combat(closest);
                        }
                        else //Move Towards
                        {
                            if (closest is Melee_Unit)
                            {
                                Melee_Unit closestMu = (Melee_Unit)closest;
                                if (mu.Xpos > closestMu.Xpos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.Xpos < closestMu.Xpos) //South
                                {
                                    mu.Move(2);
                                }
                                else if (mu.Ypos > closestMu.Ypos) //West
                                {
                                    mu.Move(3);
                                }
                                else if (mu.Ypos < closestMu.Ypos) //East
                                {
                                    mu.Move(1);
                                }
                            }
                            else if (closest is Ranged_Unit)
                            {
                                Ranged_Unit closestRu = (Ranged_Unit)closest;
                                if (mu.Xpos > closestRu.Xpos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.Xpos < closestRu.Xpos) //South
                                {
                                    mu.Move(2);
                                }
                                else if (mu.Ypos > closestRu.Ypos) //West
                                {
                                    mu.Move(3);
                                }
                                else if (mu.Ypos < closestRu.Ypos) //East
                                {
                                    mu.Move(1);
                                }
                            }
                        }

                    }
                }
                else if (map.Units[i] is Ranged_Unit)
                {
                    Ranged_Unit ru = (Ranged_Unit)map.Units[i];
                    if (ru.Health <= ru.MaxHealth * 0.25) // Running Away is commented out to make for a more interesting battle - and some insta-deaths
                    {
                         ru.Move(r.Next(0, 4));
                    }
                    else
                    {
                        (Unit closest, int distanceTo) = ru.ClosestUnit(map.Units);

                        //Check In Range
                        if (distanceTo <= ru.AttackRange)
                        {
                            ru.IsAttacking = true;
                            ru.Combat(closest);
                        }
                        else //Move Towards
                        {
                            if (closest is Melee_Unit)
                            {
                                Melee_Unit closestMu = (Melee_Unit)closest;
                                if (ru.Xpos > closestMu.Xpos) //North
                                {
                                    ru.Move(0);
                                }
                                else if (ru.Xpos < closestMu.Xpos) //South
                                {
                                    ru.Move(2);
                                }
                                else if (ru.Ypos > closestMu.Ypos) //West
                                {
                                    ru.Move(3);
                                }
                                else if (ru.Ypos < closestMu.Ypos) //East
                                {
                                    ru.Move(1);
                                }
                            }
                            else if (closest is Ranged_Unit)
                            {
                                Ranged_Unit closestRu = (Ranged_Unit)closest;
                                if (ru.Xpos > closestRu.Xpos) //North
                                {
                                    ru.Move(0);
                                }
                                else if (ru.Xpos < closestRu.Xpos) //South
                                {
                                    ru.Move(2);
                                }
                                else if (ru.Ypos > closestRu.Ypos) //West
                                {
                                    ru.Move(3);
                                }
                                else if (ru.Ypos < closestRu.Ypos) //East
                                {
                                    ru.Move(1);
                                }
                            }
                        }

                    }

                }
            }

            map.DisplayUnits(grpMap);
            //form.DisplayUnits();
        }


    }
}

