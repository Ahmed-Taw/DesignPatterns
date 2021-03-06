﻿using System;


namespace DesignPatterns.State_Pattern
{
	public class WorkItem :  ICommands
	{
		private ICommands stateCommands;
		private string state;

		internal static void Init()
		{
			
		}

		internal static WorkItem Create()
		{
			var wi = new WorkItem();
			wi.Id = -1;
			wi.State = "Proposed";
			return wi;
		}
		
		

		public int Id { get; set; }
		public string State
		{
			get { return state; }
			set
			{
				state = value.ToLower();

				// Note that if we are dynamically loading the states, this needs to be changed
				if (state == "proposed")
					stateCommands = new States.Proposed(this);
				if (state == "active")
					stateCommands = new States.Active(this);
				if (state == "resolved")
					stateCommands = new States.Resolved(this);
				if (state == "closed")
					stateCommands = new States.Closed(this);
			}
		}
		public string Title { get; set; }
		public string Description { get; set; }
		

		public bool Delete()
		{
			bool canDelete = stateCommands.Delete();
			
			return canDelete;
		}

		public void Edit(string title, string desc)
		{
			stateCommands.Edit(title, desc);
		}

		public void Print()
		{
			stateCommands.Print();
		}

		public void SetState(string newstate)
		{
			stateCommands.SetState(newstate.ToLower());
		}
		
	}
}