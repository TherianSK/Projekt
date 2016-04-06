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
        public Image image = Properties.Resources.exit;
        public Exit(int x, int y, bool solid, int weight, Player player1, Player player2) : base(x, y, false, 0)
        {
            this.player1 = player1;
            //this.player2 = player2;
        }
        public bool Escaped() {
            return (player1.X > X && player1.X < X + 20 && player1.Y > Y - 20 && player1.Y < Y + 20);
                    //&& player2.X > X && player2.X < X + 20 && player2.Y > Y-20 && player2.Y < Y + 20);
                    //zatial zakomentovane, lebo nemame este druheho hraca
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(image, X, Y);
        }
    }
}