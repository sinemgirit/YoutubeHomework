using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHomework;

namespace YoutubeHomework
{
	class MilitaryCreditManager : BaseCreditManager, ICreditManager
	{
		public override void Calculate()
		{
			Console.WriteLine("Asker Kredisi Hesaplandı");
		}
	}

	
}

