using System;
using System.Text;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using KillMessage.Database;
using NorthwoodLib.Pools;

namespace KillMessage.Commands
{
    public class Delete : ICommand
    {
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
           
            
            Player.Get(sender).UpdateMessage();
            response = Plugin.Singleton.Translation.DeleteCmd;
            return true;
        }

        public string Command { get; } = "deletekmsg";
        public string[] Aliases { get; } = new[] {"delete", "del"};
        public string Description { get; } = "删除你的击杀信息";
    }
}