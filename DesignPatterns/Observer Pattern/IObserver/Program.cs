using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer_Pattern.IObserver
{
	public class Main
	{
		public static void Start()
		{
			StockTicker st = new StockTicker();

			GoogleMonitor gf = new GoogleMonitor();
			MicrosoftMonitor mf = new MicrosoftMonitor();

			using (st.Subscribe(gf))
			using (st.Subscribe(mf))
			{
				foreach (var s in SampleData.getNext())
					st.Stock = s;
			}

		}
	}
}
