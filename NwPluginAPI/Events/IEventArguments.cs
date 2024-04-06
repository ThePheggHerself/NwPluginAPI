using PluginAPI.Enums;
using System;

namespace PluginAPI.Events
{
	public interface IEventArguments
	{
		ServerEventType BaseType { get; }
	}
}
