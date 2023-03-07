using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyancat
{
    public partial class Form1 : Form
    {
        int nyanAnimationFrame = 0;
        int rainbowAnimationFrame = 0;
        List<Control> panels = new List<Control>();

        public Form1()
        {
            InitializeComponent();

            //moveWindow nyanMoveable = new moveWindow(this, panel1);

            Timer nyanTimer = new Timer();
            nyanTimer.Interval = 50;
            nyanTimer.Tick += new EventHandler(nyanAnimationTick);
            nyanTimer.Start();

            SoundPlayer nyanSound = new SoundPlayer(@"nyancat.wav");
            nyanSound.Play();

            this.WindowState = FormWindowState.Maximized;
            panel1.Location= new Point(this.Width / 2, this.Height / 2);

            int color = 0;

            for (int i = 0; i < this.Width / 2; i += 20)
            {
                Control paneltmp = new Panel();
                paneltmp.Width = 20;
                paneltmp.Height = panel1.Size.Height;

                switch (color)
                {
                    case 0:
                        paneltmp.BackColor = Color.Blue;
                        break;
                    case 1:
                        paneltmp.BackColor = Color.Green;
                        break;
                    case 2:
                        paneltmp.BackColor = Color.Red;
                        break;
                }

                color++;
                if(color > 2) { color = 0; }
                paneltmp.Location = new Point((this.Width / 2) - i, panel1.Location.Y);

                panels.Add(paneltmp);
                this.Controls.Add(paneltmp);
            }

            Timer rainbowTimer = new Timer();

            rainbowTimer.Interval = 300;
            rainbowTimer.Tick += new EventHandler(rainbowAnimationTick);
            rainbowTimer.Start();
        }

        private void rainbowAnimationTick(object sender, EventArgs e)
        {
            for(int i = 0; i < panels.Count; i++)
            {
                Control paneltmp = panels[i];

                int offset = 0;

                switch (paneltmp.BackColor.Name)
                {
                    case "Blue":
                        if(rainbowAnimationFrame == 0){ offset = 10; }
                        if(rainbowAnimationFrame == 1){ offset = 0; }
                        if(rainbowAnimationFrame == 2){ offset = -10; }

                        paneltmp.Location = new Point(paneltmp.Location.X, panel1.Location.Y + offset);

                        break;
                    case "Green":
                        if(rainbowAnimationFrame == 0) { offset = -10; }
                        if(rainbowAnimationFrame == 1) { offset = 10; }
                        if (rainbowAnimationFrame == 2) { offset = 0; }
                        paneltmp.Location = new Point(paneltmp.Location.X, panel1.Location.Y + offset);
                        break;
                    case "Red":
                        if (rainbowAnimationFrame == 0) { offset = 0; }
                        if (rainbowAnimationFrame == 1) { offset = -10; }
                        if (rainbowAnimationFrame == 2) { offset = 10; }
                        paneltmp.Location = new Point(paneltmp.Location.X, panel1.Location.Y + offset);
                        break;
                }

                rainbowAnimationFrame++;
                if(rainbowAnimationFrame > 2)
                {
                    rainbowAnimationFrame = 0;
                }
                
            }

            
        }

        private void nyanAnimationTick(object sender, EventArgs e)
        {
            switch (nyanAnimationFrame) {
                case 0:
                    panel1.BackgroundImage = Properties.Resources._0;
                    break;
                case 1:
                    panel1.BackgroundImage = Properties.Resources._1;
                    break;
                    case 2:
                    panel1.BackgroundImage = Properties.Resources._2;
                    break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources._3;
                                        break;
                    case 4:
                    panel1.BackgroundImage = Properties.Resources._4;
                    break;
                    case 5:
                    panel1.BackgroundImage = Properties.Resources._5;
                                        break;
                    case 6:
                    panel1.BackgroundImage = Properties.Resources._6;
                                        break;
                    case 7:
                    panel1.BackgroundImage = Properties.Resources._7;
                                        break;
                    case 8:
                    panel1.BackgroundImage = Properties.Resources._8;
                    break;
                    case 9:
                    panel1.BackgroundImage = Properties.Resources._9;
                                        break;
                    case 10:
                    panel1.BackgroundImage = Properties.Resources._10;
                                        break;
                    case 11:
                    panel1.BackgroundImage = Properties.Resources._11;
                                        break;
            }

            nyanAnimationFrame++;
            if(nyanAnimationFrame> 10) { nyanAnimationFrame = 0; }
        }

        private void animationspeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
