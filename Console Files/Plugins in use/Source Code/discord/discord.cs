//Imports
//Terraria API Imports
using Terraria;
using TerrariaApi.Server;
//TShock API Imports
using TShockAPI;
using TShockAPI.Hooks;

//Other Imports
using System;
using Microsoft.Xna.Framework;

namespace discord;
//define the API Version
[ApiVersion(2, 1)]
public class discord : TerrariaPlugin
{
    //define plugin info
    //define plugin name
    public override string Name => "discord";
    //define plugin version
    public override Version Version => new Version(1,0);
    //define plugin author
    public override string Author => "Porcini";
    //define plugin description
    public override string Description => "A plugin to show the discord link";

    //Main Code
    public discord(Main game) : base(game)
    {
        //place holder
    }
    public override void Initialize(){
        ServerApi.Hooks.GameInitialize.Register(this, worldLoaded);
    }
    private void worldLoaded(EventArgs args)
    {
        Commands.ChatCommands.Add(new Command("idev.porcini.discord.use", discorduse, "discord"));
    }

    private void discorduse(CommandArgs args)
    {
        if (args.Parameters.Count == 0)
        {
            TSPlayer Player = args.Player;
            Player.SendMessage("DISCORD: https://discord.gg/h8CMJhsewK", Color.Red);
            Player.SendMessage("You can also get to to the discord from the wiki (/wiki)", Color.White);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            ServerApi.Hooks.GameInitialize.Deregister(this, worldLoaded);
        }
        base.Dispose(disposing);
    }
}