using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_21_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Hrac hrac;
		NPC npc1 = new NPC("Martin", 0, 25);
		NPC npc2 = new NPC("Jiří", 2);
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(hrac.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int oblicej=0;
			int vlasy=0;
			int barva_vlasu=0;

			switch(comboBox1.Text) {
				case "velký nos": oblicej = 0; break;
				case "ušoplesk": oblicej = 1; break;
				case "make-up": oblicej = 2; break;
			}

			switch (comboBox2.Text)
			{
				case "drdol": vlasy = 0; break;
				case "culík": vlasy = 1; break;
				case "pleška": vlasy = 2; break;
			}

			switch (comboBox3.Text)
			{
				case "kaštanová": barva_vlasu = 0; break;
				case "blond": barva_vlasu = 1; break;
				case "červená": barva_vlasu = 2; break;
			}

			hrac = new Hrac(textBox1.Text, oblicej, vlasy, barva_vlasu);
			if ((textBox1.Text).Length <= 10) {
				ResetButtons();
				button2.Enabled = true;
				button3.Image = Resource.chabr;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(0, 0);
			ResetButtons();
			button3.Image = Resource.chabr;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(0, 1);
			ResetButtons();
			button4.Image = Resource.chabr;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(0, 2);
			ResetButtons();
			button5.Image = Resource.chabr;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(1, 0);
			ResetButtons();
			button6.Image = Resource.chabr;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(1, 1);
			ResetButtons();
			button7.Image = Resource.chabr;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(1, 2);
			ResetButtons();
			button8.Image = Resource.chabr;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(2, 0);
			ResetButtons();
			button9.Image = Resource.chabr;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(2, 1);
			ResetButtons();
			button10.Image = Resource.chabr;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			hrac.ZmenaPozice(2, 2);
			ResetButtons();
			button11.Image = Resource.chabr;
		}

		private void ResetButtons()
		{
			button3.Image = null;
			button4.Image = null;
			button5.Image = null;
			button6.Image = null;
			button7.Image = null;
			button8.Image = null;
			button9.Image = null;
			button10.Image = null;
			button11.Image = null;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			MessageBox.Show(npc1.ToString());
		}

		private void button13_Click(object sender, EventArgs e)
		{
			MessageBox.Show(npc2.ToString());
		}
	}
}
