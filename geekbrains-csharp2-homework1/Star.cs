﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace geekbrains_csharp2_homework1
{
    class Star:BaseObject
    {
        public Star(Point pos, Point dir, Size size):base(pos, dir, size)
        {

        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X , Pos.Y + Size.Height);
        }

        public override void Update()
        {
            Pos.X = Pos.X - Dir.X;
            if (Pos.X > Game.Width ) Pos.X = 0 ;
            if (Pos.X < 0 ) Pos.X = Game.Width;
            Pos.Y = Pos.Y - Dir.Y;
            if (Pos.Y > Game.Height) Pos.Y = 0;
            if (Pos.Y < 0) Pos.Y = Game.Height;
        }
    }

    
}