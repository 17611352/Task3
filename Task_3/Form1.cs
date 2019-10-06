using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        Map map = new Map();
        //List<Unit> units = new List<Unit>();
        GameEngine gE;
        //Ranged_Unit ranged_Unit = new Ranged_Unit();
        //Melee_Unit melee_Unit = new Melee_Unit();

        int roundCheck = 0;


        public Form1()
        {
            InitializeComponent();
            //gE.InitializeGame();
            //map.GenerateUnits(5);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            gE = new GameEngine(Display_Group_Box);
            Test_Display_Label.Text = map.test.ToString();
            //DisplayUnits();
        }


        //public void DisplayUnits()
        //{
        //    Num_Of_Rounds.Text = "Round : " + gE.round.ToString();

        //    Display_Group_Box.Controls.Clear();
        //    foreach (Unit u in map.units)
        //    {
        //        Button newLabel = new Button();
        //        if(u is Melee_Unit)
        //        {
        //            Melee_Unit mu = (Melee_Unit)u;
        //            newLabel.Width = 25;
        //            newLabel.Height = 25;
        //            newLabel.Location = new Point(mu.Xpos * 20, mu.Ypos * 15);
        //            newLabel.Text = mu.Symbol;
        //            if (mu.Team == "Blue")
        //            {
        //                newLabel.ForeColor = Color.Blue;
        //            }
        //            else
        //            {
        //                newLabel.ForeColor = Color.Red;
        //            }
        //        }
        //        else
        //        {
        //            Ranged_Unit ru = (Ranged_Unit)u;
        //            newLabel.Width = 25;
        //            newLabel.Height = 25;
        //            newLabel.Location = new Point(ru.Xpos * 20, ru.Ypos * 15);
        //            newLabel.Text = ru.Symbol;
        //            if (ru.Team == "Blue")
        //            {
        //                newLabel.ForeColor = Color.Blue;
        //            }
        //            else
        //            {
        //                newLabel.ForeColor = Color.Red;
        //            }
        //        }
                

        //        Display_Group_Box.Controls.Add(newLabel);
        //    }


        //    foreach(Building bd in map.Buildings)
        //    {
        //        Button newLabel = new Button();
        //        newLabel.Width = 30;
        //        newLabel.Height = 30;
        //        newLabel.Location = new Point(bd.xPosition * 20, bd.yPosition * 15);
        //        newLabel.Text = bd.symbol;
        //        if(bd.team >= 3)
        //        {
        //            newLabel.ForeColor = Color.Blue;
        //        }
        //        else
        //        {
        //            newLabel.ForeColor = Color.Red;
        //        }

        //        Display_Group_Box.Controls.Add(newLabel);
        //    }

        //}


        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Test_Display_Label.Text = map.Buildings.Count.ToString();
            Test_Display_Label.Text = "Num Of Controls in GroupBox : " + Display_Group_Box.Controls.Count.ToString();
            Buildings_In_Game.Text = "Buildings in Game : " + map.Buildings.Count.ToString();
            Num_Of_Units_InGame.Text = "Units in Game : " + map.Units.Count.ToString();
            Num_Of_Rounds.Text = "Round : " + gE.NumOfRound().ToString();

            map.SpawnUnitAtFactory();

            gE.UpdateMovement();

            /*foreach (Building bd in map.Buildings)
            {

                if (bd is FactoryBuilding)
                {
                    if (bd.symbol == "F" && bd.team < 3)
                    {
                        if (gE.round >= roundCheck)
                        {
                            Ranged_Unit rU = new Ranged_Unit(bd.xPosition, bd.yPosition + 5, 100, 1, 20, 5, "[!]", "Red");
                            //rU.Xpos = bd.xPosition;
                            //rU.Ypos = bd.yPosition + 5;
                            //rU.Symbol = "[!]";
                            //rU.Health = 100;
                            //rU.Attack = 20;
                            //rU.AttackRange = 5;
                            //rU.IsAttacking = false;
                            //rU.IsDead = false;
                            //rU.Team = "Red";

                            map.Units.Add(rU);
                        }
                        else
                        {
                            Melee_Unit mU = new Melee_Unit(bd.xPosition, bd.yPosition + 5, 200, 1, 20, 1, "{:}", "Red");
                            //mU.Xpos = bd.xPosition;
                            //mU.Ypos = bd.xPosition + 5;
                            //mU.Symbol = "{:}";
                            //mU.Health = 200;
                            //mU.Attack = 20;
                            //mU.AttackRange = 1;
                            //mU.IsAttacking = false;
                            //mU.IsDead = false;
                            //mU.Team = "Red";

                            map.Units.Add(mU);
                        }

                    }
                    else if (bd.symbol == "F" && bd.team >= 3)
                    {
                        if (gE.round >= roundCheck)
                        {
                            Ranged_Unit rU = new Ranged_Unit(bd.xPosition, bd.yPosition + 5, 100, 1, 20, 5, "[!]", "Red");
                            //rU.Xpos = bd.xPosition;
                            //rU.Ypos = bd.yPosition + 5;
                            //rU.Symbol = "[!]";
                            //rU.Health = 100;
                            //rU.Team = "Blue";

                            map.Units.Add(rU);
                        }
                        else
                        {
                            Melee_Unit mU = new Melee_Unit(bd.xPosition, bd.yPosition + 5, 200, 1, 20, 1, "{:}", "Blue");
                            //mU.Xpos = bd.xPosition;
                            //mU.Ypos = bd.xPosition + 5;
                            //mU.Symbol = "{:}";
                            //mU.Health = 200;
                            //mU.Team = "Blue";

                            map.Units.Add(mU);
                        }

                    }
                }


                roundCheck += 5;
            }

            */
            //map.UpdateUnitMovement();
            //DisplayUnits();
            //Test_Display_Label.Text = map.Units.Count().ToString();

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            //map.UpdateUnitMovement();
            //DisplayUnits();

            if (Map_Size_X_Control.Value >= 5 && Map_Size_X_Control.Value <= 100 && Map_Size_Y_Control.Value >= 5 && Map_Size_X_Control.Value <= 100)
            {
                map.xMapSize = Convert.ToInt32(Map_Size_X_Control.Value);
                map.yMapSize = Convert.ToInt32(Map_Size_Y_Control.Value);

                timer1.Enabled = true;
            }
            else
            {
                Map_Size_X_Control.Value = 0;
                Map_Size_Y_Control.Value = 0;
            }

        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

    }
}
