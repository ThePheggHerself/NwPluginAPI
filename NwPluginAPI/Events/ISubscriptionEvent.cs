using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAPI.Events
{
	public interface ISubscriptionEvent
	{
		public bool IsCancelled { get; set; }

		internal void invoke();
	}
}
