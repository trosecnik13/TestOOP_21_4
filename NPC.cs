using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_21_4
{
	class NPC : HerniPostava
	{
		enum Prace
		{
			obchodnik,
			nepritel,
			obyvatel
		}
		private Prace prace;
		public int sila;

		public NPC(string jmeno, int prace, int sila) : base(jmeno)
		{
			this.jmeno = jmeno;
			this.prace = (Prace)prace;
			this.sila = sila;
		}

		public NPC(string jmeno, int prace) : base(jmeno)
		{
			this.jmeno = jmeno;
			this.prace = (Prace)prace;
		}

		public override void ZmenaPozice(int x, int y)
		{
			
		}

		public override string ToString()
		{
			if (sila == 0) { return $"jmeno: {jmeno}, level: {level}, pozice x: {pozice_X}, pozice y: {pozice_Y}, prace: {prace}"; }
			else { return $"BOSS, jmeno: {jmeno}, level: {level}, pozice x: {pozice_X}, pozice y: {pozice_Y}, sila: {sila}, prace: {prace}"; }
		}
	}
}
