using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStoreProj_Perez
{
    public partial class UserHome : Form
    {
        int imgnum = 1;
        int titlemov = 0;
        int description = 0;
        public UserHome()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Enabled = true;
            comboBox2.FlatStyle = FlatStyle.Flat;
            label16.TextAlign = ContentAlignment.TopLeft;
            label14.Text = "Scary Movie";
            label16.Text = "Scary Movie out-parodies the pop culture parodies with a no-holds barred assault on the most popular images and talked-about moments from recent films";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string imagefolder = @"..\..\..\slideshow\";
            string imagepath = Path.Combine(imagefolder, $"movie{imgnum}.jpg");
            pictureBox4.Image = Image.FromFile(imagepath);
            imgnum++;
            List<string> title = new List<string>() { "Scary Movie", "Shrek", "Legally Blonde", "You Don't Mess with the Zohan" };
            List<string> desc = new List<string>()
            { "Scary Movie out-parodies the pop culture parodies with a no-holds barred assault on the most popular images and talked-about moments from recent films",
                "Once upon a time, in a far away swamp, there lived an ogre named Shrek (Mike Myers)",
                "Elle Woods (Reese Witherspoon) has it all. She wants nothing more than to be Mrs. Warner Huntington III.",
                "Crack commando Zohan Dvir is Israel's first line of defence against terrorism" };
            label5.Text = title[titlemov];
            label6.Text = desc[titlemov];
            titlemov++;
            description++;
            if (titlemov == 4 && description == 4)
            {
                titlemov = 0;
                description = 0;
            }
            if (imgnum == 5)
                imgnum = 1;

        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = label9;
        }
    }
}
