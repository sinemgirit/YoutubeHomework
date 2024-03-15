using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHomework;

namespace YoutubeHomework
{
	class CustomerManager
	{
		private Customer _customer;
		private ICreditManager _creditManager;
		public CustomerManager(Customer customer,ICreditManager creditManager)
		{
			_creditManager = creditManager;
			_customer = customer;
		}
		public void Save()
		{
			Console.WriteLine("Müşteri Kaydedildi");
		}
		public void Delete()
		{
			Console.WriteLine("Müşteri Silindi");
		}
		public void GiveCredit()
		{
			_creditManager.Calculate();
			Console.WriteLine("Kredi Verildi");
		}
	}
}
