using PluginAPI.Enums;
using System;

namespace PluginAPI.Events
{
	public class WaitingForPlayersEvent :IEventArguments, ISubscriptionEvent
	{
		public static event Action<WaitingForPlayersEvent> Event;

		public ServerEventType BaseType { get; } = ServerEventType.WaitingForPlayers;

		public bool IsCancelled { get; set; }

		void ISubscriptionEvent.invoke()
		{
			Event?.Invoke(this);
		}
	}
}
