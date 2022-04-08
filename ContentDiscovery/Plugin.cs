﻿using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Data;
using Dalamud.Game.ClientState;

namespace ContentDiscovery;
public class Plugin : IDalamudPlugin
{
    public string Name => "Name the Content";

    private readonly Discovery _discovery;

    public Plugin(
        [RequiredVersion("1.0")] ClientState client,
        [RequiredVersion("1.0")] DataManager data,
        [RequiredVersion("1.0")] ChatGui chat
    )
    {
        _discovery = new Discovery(client, data, chat);
    }

    public void Dispose()
    {
        _discovery.Dispose();
    }
}