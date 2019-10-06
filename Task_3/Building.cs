using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public abstract class Building
    {
        internal int xPosition;
        internal int yPosition;
        internal int health;
        internal int maxHealth;
        internal int team;
        internal string symbol;

        public abstract void Death();

        public abstract override string ToString();

    }
}
