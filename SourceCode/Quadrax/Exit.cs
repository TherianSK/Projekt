﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrax
{
    class Exit : GameObject
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public string image = "/Graphics/exit.png";
        public Exit(int x, int y, bool solid, int weight, Player player1, Player player2) : base(x, y, false, 0)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public bool Escaped() {
            return (player1.getX() > X && player1.getX() < X + 20 && player1.getY() > Y-20 && player1.getY() < Y + 20 &&
                    player2.getX() > X && player2.getX() < X + 20 && player2.getY() > Y-20 && player2.getY() < Y + 20);
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, new Rectangle(X, Y, 20, 20));
        }
    }
}
