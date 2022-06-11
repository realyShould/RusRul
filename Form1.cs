using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RusRul
{
    public partial class Main : Form
    {
        private List<bool> mag;
        int countBullets;
        int score = 0;
        int hscore = 0;
        int position = -1;

        public Main()
        {
            InitializeComponent();
            countBullets = (int)numericBullets.Value;
            Reload();
        }

        string addText(string text, Label lab)
        {
            string tmp = lab.Text;
            text = text + "\n" + tmp;
            return text;
        }

        List<bool> nG(int bullets)
        {
            mag = new List<bool> { false, false, false, false, false, false };
            Random rnd = new Random();
            while (bullets != 0)
            {
                int tmp = rnd.Next(0, 5);
                if (mag[tmp] == false)
                {
                    mag[tmp] = true;
                    bullets--;
                }
                else
                {
                    bullets++;
                }
            }
            return mag;
        }

        List<bool> Shift(List<bool> aList)
        {
            List<bool> tmp = new List<bool>() { aList[1], aList[2], aList[3], aList[4], aList[5], aList[0] };
            return tmp;
        }

        void Spin()
        {
            Random rnd = new Random();
            for(int tmp = rnd.Next(1, 10); tmp > 0; tmp--)
            {
                Shift(mag);
            }
            position = 0;
        }

        void Reload()
        {
            score = 0;
            mag = nG((int)numericBullets.Value);
            countBullets = (int)numericBullets.Value;
        }
        void Fire()
        {
            if (position > 5)
                position = 0;
            if (mag[position])
            {
                labelStatus.Text = addText("Boom. Restart", labelStatus);
                position = -1;
                Reload();
            }
            else
            {
                labelStatus.Text = addText("Click. Lucky day)", labelStatus);
                score++;
                labelScore.Text = "Score: " + score;
                if (score > hscore)
                    hscore = score;
                labelHscore.Text = "Hight Score: " + hscore;
                position++;
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                position = 0;
            }
            
            Fire();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            Spin();
        }

        private void numericBullets_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
