//Imports
//Terraria API Imports
using Terraria;
using TerrariaApi.Server;
//TShock API Imports
using TShockAPI;
using TShockAPI.Hooks;

//Other Imports
using System;

namespace says;
//define the API Version
[ApiVersion(2, 1)]
public class says : TerrariaPlugin
{
    //define plugin info
    //define plugin name
    public override string Name => "says";
    //define plugin version
    public override Version Version => new Version(1,0);
    //define plugin author
    public override string Author => "Porcini";
    //define plugin description
    public override string Description => "A plugin to speek as an admin";

    //Main Code
    public says(Main game) : base(game)
    {
        //place holder
    }
    public override void Initialize(){
        ServerApi.Hooks.GameInitialize.Register(this, worldLoaded);
    }
    private void worldLoaded(EventArgs args)
    {
        Commands.ChatCommands.Add(new Command("idev.porcini.says.ms.use", porcinisay, "m"));
        Commands.ChatCommands.Add(new Command("idev.porcini.says.ss.use", sparrowhawksay, "s"));
        Commands.ChatCommands.Add(new Command("idev.porcini.says.us.use", uldruldorsay, "u"));
    }

    private void porcinisay(CommandArgs args)
    {
        if (args.Parameters.Count > 0)
        {
            string message = string.Join(" ", args.Parameters);
            TShock.Utils.Broadcast("(Owner, I do what I please!)Porcini(Breaker of Things) (Console): " + message, Convert.ToByte(219), Convert.ToByte(65), Convert.ToByte(5));
        }
    }

    private void sparrowhawksay(CommandArgs args)
    {
        if (args.Parameters.Count > 0)
        {
            string message = string.Join(" ", args.Parameters);
            TShock.Utils.Broadcast("(Admin)SparrowHawk(Torch God's Apprentice) (Console): " + message, Convert.ToByte(255), Convert.ToByte(0), Convert.ToByte(0));
        }
    }

    private void uldruldorsay(CommandArgs args)
    {
        if (args.Parameters.Count > 0)
        {
            string message = string.Join(" ", args.Parameters);
            TShock.Utils.Broadcast("(Admin)Uldruldor(I'm Trusted!) (Console): " + message, Convert.ToByte(255), Convert.ToByte(0), Convert.ToByte(0));
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