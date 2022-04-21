using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_21_4
{
	class HerniPostava
	{
		private string Jmeno;
		public string jmeno { get { return Jmeno; } set {  
			if (value.Length > 10) { MessageBox.Show("Příliš dlouhé jméno!"); }
			else Jmeno = value;
		} }
		protected int level = 1;
		private int Pozice_X = 0;
		private int Pozice_Y = 0;
		public int pozice_X { get { return Pozice_X; } set { } }
		public int pozice_Y { get { return Pozice_Y; } set { } }

		public HerniPostava(string jmeno)
		{
			this.jmeno = jmeno;
		}

		public virtual void ZmenaPozice(int x, int y)
		{
			this.Pozice_X = x;
			this.Pozice_Y = y;
		}

		public override string ToString()
		{
			return $"jmeno: {jmeno}, level: {level}, pozice x: {pozice_X}, pozice y: {pozice_Y}";
		}
	}
}
