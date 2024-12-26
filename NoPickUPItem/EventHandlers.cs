using System;
using System.Collections.Generic;
using AdminToys;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.Events.EventArgs.Player;
using Exiled.Permissions;
using PlayerRoles;
using PluginAPI.Core.Attributes;

namespace NoPickUPItem;
public class EventHandlers
{
    public void OnPlayerPickUpItem(SearchingPickupEventArgs ev)
    {
        if (ev.Player.Role != null && Plugin.Singleton.Config.DeniedRoles.Contains(ev.Player.Role))
        {
            if (ev.Pickup != null && Plugin.Singleton.Config.NoPickUpItem.Contains(ev.Pickup.Type))
            {
                ev.IsAllowed = Plugin.Singleton.Config.IsAllowed;
                ev.Player.ShowHint(Plugin.Singleton.Config.ShowHint, Plugin.Singleton.Config.ShowHintDuration);
            }
        } 
    }
}