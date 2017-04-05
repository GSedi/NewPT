﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        DrawClass draw = new DrawClass();
        Graphics g;
        SolidBrush blue;
        SolidBrush yellow;
        SolidBrush red;
        SolidBrush white;
        SolidBrush green;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            blue = new SolidBrush(Color.Blue);
            yellow = new SolidBrush(Color.Yellow);
            red = new SolidBrush(Color.Red);
            white = new SolidBrush(Color.White);
            green = new SolidBrush(Color.Green);

            draw.Space(0, 0, this.Width, this.Height);

            draw.Ship(492, 325);

            draw.Stars(50, 110);
            draw.Stars(400, 60);
            draw.Stars(650, 100);
            draw.Stars(880, 275);
            draw.Stars(770, 400);
            draw.Stars(865, 570);
            draw.Stars(380, 500);
            draw.Stars(70, 510);

            draw.Bullet(487, 240);

            draw.Gun(492, 325);

            draw.Asters(180, 200);
            draw.Asters(220, 450);
            draw.Asters(800, 170);
            draw.Asters(610, 510);

            label2.Text = "Level: 1 Score: 200  Live: ***";

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            g.FillPath(blue, draw.path8);

            g.FillPath(yellow, draw.path1);

            g.FillPath(white, draw.path2);

            g.FillPath(green, draw.path3);
            g.FillPath(green, draw.path4);

            g.FillPath(green, draw.path5);

            g.FillPath(red, draw.path6);
            g.FillPath(red, draw.path7);

            

        }

        
    }
}
