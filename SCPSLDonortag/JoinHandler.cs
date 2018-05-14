﻿using Smod2.API;
using Smod2;
using Smod2.Events;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SCPSLDonortag
{
    class JoinHandler : IEventPlayerJoin
    {
        private SCPSLDonortag plugin;
        public JoinHandler(Plugin plugin)
        {
            this.plugin =(SCPSLDonortag) plugin;
        }

        public void OnPlayerJoin(Player player)
        {
            

                List<String> steamIDs = plugin.getSteamIDs();
                if (player == null || player.SteamId == null)
                {
                    plugin.Error("ID or player is null");
                }
                if (steamIDs.Contains(player.SteamId))
                {
                    String tag = plugin.getTag();
                    String color = plugin.getColor();
                    player.SetRole(color, tag);
                }

        }
    }
}