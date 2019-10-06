using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ResourceBuilding : Building
    {
        string resourceType;
        int resourcesGenerated;
        int resourcesGeneratedPerRound;
        int resourcesPoolRemaining;

        public ResourceBuilding(int xPosition, int yPosition, int health, int team, string symbol)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Health = health;
            Team = team;
            Symbol = symbol;
        }

        public int XPosition
        {
            get { return base.xPosition; }
            set { base.xPosition = value; }
        }

        public int YPosition
        {
            get { return base.yPosition; }
            set { base.yPosition = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        public int Team
        {
            get { return base.team; }
            set { base.team = value; }
        }

        public string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }






        public void GenerateResources()
        {
            if(resourcesPoolRemaining >= 0)
            {
                resourcesGenerated++;
                resourcesPoolRemaining--;
            }
        }


        public override void Death()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
