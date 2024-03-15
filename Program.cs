//using System;
//using YoutubeHomework;

//CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
//customerManager.GiveCredit();




using System;
using YoutubeHomework;

namespace NesneYönelimliProgramlama
{
	class Program
	{
		static void Main(string[] args)
		{


			CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
			customerManager.GiveCredit();
		}
	}
}