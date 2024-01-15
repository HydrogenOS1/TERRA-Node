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
namespace aboutplugin;
//define the API Version
[ApiVersion(2, 1)]
public class about : TerrariaPlugin
{
    //plugin info
    public override string Name => "about";
    public override Version Version => new Version(1,0);
    public override string Author => "Porcini";
    public override string Description => "A plugin to tell you about a admin, mod or dev";
    public about(Main game) : base(game){}
    public string porciniinfo = "Porcini is the owner, basic developer and host of TerraNODE. Their alt is Developer Porcini.";
    public string developerporciniinfo = "Developer Porcini is one of Porcini's accounts that they use for testing the server plugins";
    public string sparrowhawkinfo = "sparrowhawk info";
    public string uldruldorinfo = "Uldruldor, also know as Lord of Spuds is a basic admin for TerraNODE. He is a programmer and Terraria sweat who picks expert mode because he thinks he's good at the game.";

    public override void Initialize(){
        //register /porcini and the "idev.porcini.about.porcini.use"
        Commands.ChatCommands.Add(new Command("idev.porcini.about.use", porcinicommand, "porcini"));
        Commands.ChatCommands.Add(new Command("idev.porcini.about.use", devporcinicommand, "developerporcini"));
        Commands.ChatCommands.Add(new Command("idev.porcini.about.use", sparrowhawkcommand, "sparrowhawk"));
        Commands.ChatCommands.Add(new Command("idev.porcini.about.use", uldruldorcommand, "uldruldor"));
    }
    private void porcinicommand(CommandArgs args){
        //check if there are args
        if (args.Parameters.Count == 0){
            TSPlayer Player = args.Player;
            Player.SendMessage(porciniinfo, Color.Red);
        }
    }
    private void devporcinicommand(CommandArgs args)
    {
        //check if there are args
        if (args.Parameters.Count == 0)
        {
            TSPlayer Player = args.Player;
            Player.SendMessage(developerporciniinfo, Color.Red);
        }
    }
    private void sparrowhawkcommand(CommandArgs args)
    {
        //check if there are args
        if (args.Parameters.Count == 0)
        {
            TSPlayer Player = args.Player;
            Player.SendMessage(sparrowhawkinfo, Color.Red);
        }
    }
    private void uldruldorcommand(CommandArgs args)
    {
        //check if there are args
        if (args.Parameters.Count == 0)
        {
            TSPlayer Player = args.Player;
            Player.SendMessage(uldruldorinfo, Color.Red);
        }
    }
}