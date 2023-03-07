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

        int rainbowAnimationFrame = 0;
        List<Control> panels = new List<Control>();

        NyanCat nyanCat = new NyanCat();
        RainbowForm rainbow = new RainbowForm();

        public Form1()
        {
            

            InitializeComponent();

            Timer rainbowTimer = new Timer();
            rainbowTimer.Interval = 1;
            rainbowTimer.Tick += new EventHandler(rainbowAnimationTick);
            rainbowTimer.Start();

            nyanCat.Show();
            rainbow.Show();

            //this.WindowState = FormWindowState.Maximized;

            /*
            
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

            */

        }
       
        private void rainbowAnimationTick (object sender, EventArgs e)
        {
            rainbow.catPosition = nyanCat.Location;
            rainbow.catSize = nyanCat.Size;
        }

        /*
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
        */

        

        private void animationspeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
