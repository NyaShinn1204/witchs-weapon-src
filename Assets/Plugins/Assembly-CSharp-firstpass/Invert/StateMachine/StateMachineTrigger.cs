using System;
using System.Collections.Generic;
using UniRx;

namespace Invert.StateMachine
{
	public class StateMachineTrigger : IObserver<Unit>, IObserver<bool>
	{
		private List<Func<bool>> _computers;

		public StateMachine StateMachine { get; set; }

		public string Name { get; set; }

		public List<Func<bool>> Computers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StateMachineTrigger(StateMachine stateMachine, string name)
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(bool value)
		{
		}

		public void OnNext(Unit value)
		{
		}

		public void AddComputer(P<bool> computed)
		{
		}
	}
}
