﻿using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewModdingAPI.Events
{
    public static class PlayerEvents
    {
        public static event EventHandler<EventArgsFarmerChanged> FarmerChanged = delegate { };
        public static event EventHandler<EventArgsInventory> InventoryChanged = delegate { };

        public static void InvokeFarmerChanged(Farmer priorFarmer, Farmer newFarmer)
        {
            FarmerChanged.Invoke(null, new EventArgsFarmerChanged(priorFarmer, newFarmer));
        }

        public static void InvokeInventoryChanged(List<Item> inventory)
        {
            FarmerChanged.Invoke(null, new InventoryChanged(inventory));
        }
    }
}