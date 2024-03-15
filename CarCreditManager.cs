using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHomework;

namespace YoutubeHomework
{
	class CarCreditManager:BaseCreditManager,ICreditManager
	{
		public override void Calculate()
		{
			Console.WriteLine("Araba Kredisi Hesaplandı");
		}
	}
}


