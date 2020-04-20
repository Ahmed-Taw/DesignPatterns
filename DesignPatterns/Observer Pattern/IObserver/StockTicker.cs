using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer_Pattern.IObserver
{
	class StockTicker : IObservable<Stock>
	{
		List<IObserver<Stock>> Observers = new List<IObserver<Stock>>();

		private Stock stock;
		public Stock Stock
		{
			get { return stock; }
			set
			{
				stock = value;
				this.Notify(this.stock);
			}
		}

		private void Notify(Stock s)
		{
			foreach (var o in Observers)
			{
				if (s.Symbol == null || s.Price < 0)
					o.OnError(new Exception("Bad Stock Data"));
				else
					o.OnNext(s);
			}
		}
		private void Stop()
		{
			foreach (var Observer in Observers.ToArray())
				if (Observers.Contains(Observer))
					Observer.OnCompleted();
			Observers.Clear();
		}

		public IDisposable Subscribe(IObserver<Stock> Observer)
		{
			if (!Observers.Contains(Observer))
				Observers.Add(Observer);
			return new Unsubscriber(Observers, Observer);
		}

		private class Unsubscriber : IDisposable
		{
			private List<IObserver<Stock>> _Observers;
			private IObserver<Stock> _Observer;

			public Unsubscriber(List<IObserver<Stock>> Observers, IObserver<Stock> Observer)
			{
				this._Observers = Observers;
				this._Observer = Observer;
			}

			public void Dispose()
			{
				if (_Observer != null && _Observers.Contains(_Observer))
					_Observers.Remove(_Observer);
			}
		}
	}
}
