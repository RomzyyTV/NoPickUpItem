﻿using Exiled.API.Features;
using System;
using Exiled.API.Enums;

namespace NoPickUPItem;

public class Plugin : Plugin<Config>
{
    public override string Author => "By RomzyyTV";
    public override string Name => "No PickUP Item";
    public override Version Version => new Version(1, 1,0);
    public override Version RequiredExiledVersion { get; } = new(8, 11, 0);
    public PluginPriority Priority { get; } = PluginPriority.Default;
    public static Plugin Singleton;
    public static EventHandlers Handlers;

    public override void OnEnabled()
    {
        Singleton = this;
        Handlers = new EventHandlers();

        Exiled.Events.Handlers.Player.SearchingPickup += Handlers.OnPlayerPickUpItem;
        base.OnEnabled();
    }

    public override void OnDisabled()
    {
        Singleton = null;
        Handlers = null;

        Exiled.Events.Handlers.Player.SearchingPickup -= Handlers.OnPlayerPickUpItem;
        base.OnDisabled();
    }
}