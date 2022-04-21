using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_21_4
{
	class Hrac : HerniPostava
	{
		private string Specializace;
		public string specializace
		{
			get { return Specializace; }
			set
			{
				if (value == "Kouzelník" || value == "Berserker" || value == "Inženýr" || value == "Cizák")
				{
					Specializace = value;
				}
				else { MessageBox.Show("Nepřijatelné!"); }
			}
		}

		enum Oblicej
		{
			velky_nos,
			usoplesk,
			make_up
		}
		enum Vlasy
		{
			drdol,
			culik,
			pleska
		}

		enum Barva_vlasu
		{
			kastanova,
			blond,
			cervena
		}

		private Oblicej oblicej;
		private Vlasy vlasy;
		private Barva_vlasu barva_vlasu;
		public int xp = 0;

		public Hrac(string jmeno, int oblicej, int vlasy, int barva_vlasu) : base(jmeno)
		{
			this.jmeno = jmeno;
			this.oblicej = (Oblicej)oblicej;
			this.vlasy = (Vlasy)vlasy;
			this.barva_vlasu = (Barva_vlasu)barva_vlasu;
		}

		public void PridejXP(int xp)
		{
			this.xp += xp;
			if ((100 * this.level) <= this.xp)
			{
				this.level++;
			}
		}

		public override string ToString()
		{
			return $"jmeno: {jmeno}, level: {level}, pozice x: {pozice_X}, pozice y: {pozice_Y}, oblicej: {oblicej}, vlasy: {vlasy}, barva_vlasu: {barva_vlasu}";
		}

	}
}
