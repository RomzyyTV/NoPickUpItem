﻿using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace NoPickUPItem;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
		
    public bool Debug { get; set; }
    
    [Description("Can the player take the item (if he can't then = false or if he can't = true)")]
    public bool IsAllowed { get; set; } = false;
    
    [Description("")]
    public string ShowHint { get; set; } = "<b>You can't take this item</b>";
    
    public float ShowHintDuration { get; set; } = 4f;
    
    [Description("The role that cannot take the item or items that were chosen")]
    public List<ItemType> NoPickUpItem { get; set; } = new List<ItemType>() 
    { 
        ItemType.GunCrossvec
    };

    public List<RoleTypeId> DeniedRoles { get; set; } = new List<RoleTypeId>()
    {
        RoleTypeId.Scientist
    };
}