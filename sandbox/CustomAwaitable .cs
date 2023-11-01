using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
	//custom awaitable
	public class CustomAwaitable : INotifyCompletion
	{
		private bool _isCompleted;
		public CustomAwaitable GetAwaitable() => this;
		public bool IsCompleted => _isCompleted;

		public void OnCompleted(Action continuation)
		{
			Task.Delay(1000).ContinueWith(t => {
				_isCompleted = true;
				continuation?.Invoke();
			});
		}

		public int GetResult() => 42;
	}
}
