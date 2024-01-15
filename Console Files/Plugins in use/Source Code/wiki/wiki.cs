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
namespace wiki;
//define the API Version
[ApiVersion(2, 1)]
public class wiki : TerrariaPlugin
{
    //plugin info
    public override string Name => "wiki";
    public override Version Version => new Version(1,0);
    public override string Author => "Porcini";
    public override string Description => "A plugin to print the wiki link";
    public wiki(Main game) : base(game){}
    public override void Initialize(){
        //register /wiki and the "idev.porcini.wiki.use"
        Commands.ChatCommands.Add(new Command("idev.porcini.wiki.use", wikicommand, "wiki"));
    }
    private void wikicommand(CommandArgs args){
        //check if there are args
        if (args.Parameters.Count == 0){
            TSPlayer Player = args.Player;
            //print the "WIKI" message
            Player.SendMessage("WIKI: https://malcolmjh.com/wiki", Color.Red);
        }
    }
}