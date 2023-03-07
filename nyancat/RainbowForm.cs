using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyancat
{
    public partial class RainbowForm : Form
    {
        public Point catPosition;
        public Size catSize;

        bool rainbowAnimationFrame = false;

        public RainbowForm()
        {
            InitializeComponent();

            moveWindow rainbowMovable = new moveWindow(this, panel1);

            Timer rainbowTimer = new Timer();
            rainbowTimer.Interval = 1;
            rainbowTimer.Tick += new EventHandler(rainbowTimerTick);
            rainbowTimer.Start();
            
            Timer rainbowAnimationTimer = new Timer();
            rainbowAnimationTimer.Interval = 300;
            rainbowAnimationTimer.Tick += new EventHandler(rainbowAnimationTick);
            rainbowAnimationTimer.Start();
        }

        private void rainbowAnimationTick(object sender, EventArgs e)
        {
            if(rainbowAnimationFrame == true)
            {
                rainbowAnimationFrame = false;
                panel1.BackgroundImage = Properties.Resources.rainbow;
            }
            else if(rainbowAnimationFrame == false)
            {
                rainbowAnimationFrame = true;
                panel1.BackgroundImage= Properties.Resources.rainbow2;
            }
        }


        private void rainbowTimerTick(object sender, EventArgs e)
        {
            this.Size = new Size(catPosition.X + 70, 168);
            this.Location = new Point(0, catPosition.Y);
            
        }
    }
}
