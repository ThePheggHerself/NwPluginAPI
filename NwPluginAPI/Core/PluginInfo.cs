using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAPI.Core
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class PluginInfo : Attribute
	{
		public string Name { get; }
		public string Version { get; }
		public string Description { get; }
		public string Author { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PluginEntryPoint"/> class.
		/// </summary>
		/// <param name="pluginName">The plugin name.</param>
		/// <param name="pluginVersion">The plugin version.</param>
		/// <param name="description">The plugin description.</param>
		/// <param name="author">The plugin author.</param>
		public PluginInfo(string pluginName, string pluginVersion, string description, string author)
		{
			Name = pluginName;
			Author = author;
			Description = description;
			Version = pluginVersion;
		}

		public PluginInfo()
		{
			Name = "UNKNOWN";
			Version = "0.0.0.0";
			Description = "NODESCRIPTION";
			Author = "UNKNOWN";
		}
	}
}
