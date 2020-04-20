using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.State_Pattern
{
	interface ICommands
	{
		bool Delete();
		void Edit(string title, string desc);
		void Print();
		void SetState(string state);
	}
}
