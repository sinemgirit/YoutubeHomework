using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHomework;

namespace YoutubeHomework
{
	class TeacherCreditManager : BaseCreditManager, ICreditManager
	{
		public override void Calculate()
		{
			Console.WriteLine("Öğretmen Kredisi Hesaplandı");
		}

		public override void Save()
		{
			//base.Save();
		}

	}
}


