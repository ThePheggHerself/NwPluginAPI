using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAPI.Core
{
	public class PluginBase
	{
		public PluginInfo Info { get; set; }
		public Type Config { get; set; }

		public PluginBase() {
			var att = Attribute.GetCustomAttribute(this.GetType(), typeof(PluginInfo));
			Info = att != null ? (PluginInfo)att : new PluginInfo();
		}

		public virtual void OnEnable()
		{

		}

		public virtual void OnDisable()
		{

		}
	}
}
