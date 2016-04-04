﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrax
{
    class Boulder : GameObject
    {
        //constructor
        public Boulder(int x, int y, bool solid, int weight) : base(x, y, true, 20)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, new Rectangle(this.X, this.Y, 20, 20));
        }

    }
}