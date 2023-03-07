using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyancat
{
    public partial class Form1 : Form
    {
        int nyanAnimationFrame = 0;

        public Form1()
        {
            InitializeComponent();

            Timer nyanTimer = new Timer();
            nyanTimer.Interval = 50;
            nyanTimer.Tick += new EventHandler(nyanAnimationTick);
            nyanTimer.Start();
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
    }
}
