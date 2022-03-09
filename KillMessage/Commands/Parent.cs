﻿using System;
using System.Runtime.InteropServices;
using CommandSystem;
using CommandSystem.Commands.RemoteAdmin.PermissionsManagement.Group;
using CustomPlayerEffects;
using Exiled.Permissions.Extensions;
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
            if (Plugin.Singleton.Config.UsePermissions && !sender.CheckPermission("kmsg"))
            {
                response = Plugin.Singleton.Translation.NoPerms;
                return false;
            }

            response = Plugin.Singleton.Translation.HelpMessage;
            return true;
        }

        public override string Command { get; } = "killmessage";
        public override string[] Aliases { get; } = {"kmsg"};
        public override string Description { get; } = "Sets or deletes your kill message. Available commands: kmsg set, kmsg delete, kmsg toggle, kmsg color";
        
    }
}