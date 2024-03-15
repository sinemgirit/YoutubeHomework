using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHomework;

namespace YoutubeHomework
{
abstract class BaseCreditManager : ICreditManager
{
	public abstract void Calculate();

	public virtual void Save()
	{
		Console.WriteLine("Kaydedildi");
	}
}
}