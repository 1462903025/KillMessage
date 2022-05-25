﻿using System;
using System.Runtime.InteropServices;
using CommandSystem;
using CommandSystem.Commands.RemoteAdmin.PermissionsManagement.Group;
using CustomPlayerEffects;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using KillMessage.Database;
using Mirror;

namespace KillMessage.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Parent : ParentCommand
    {
        public Parent() => LoadGeneratedCommands();
        public override void LoadGeneratedCommands()
        {
            RegisterCommand(new Set());
            RegisterCommand(new Delete());
            RegisterCommand(new Toggle());
            RegisterCommand(new SetColor());
        }
        
        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("kmsg"))
            {
                response = Plugin.Singleton.Translation.NoPerms;
                return false;
            }

            Player p = Player.Get(sender);
            string current = p.GetMessage();
            string color = p.GetColor();
            response = Plugin.Singleton.Translation.HelpMessage.Replace($"$current", string.IsNullOrEmpty(current) ? Plugin.Singleton.Translation.MessageNotSet : current).Replace("$color", color);
            return true;
        }

        public override string Command { get; } = "killmessage";
        public override string[] Aliases { get; } = {"kmsg"};
        public override string Description { get; } = "设置或删除您的击杀信息。可用命令：ksmg set，ksmg delete，kmsg toggle，kmsg color";
        
    }
}