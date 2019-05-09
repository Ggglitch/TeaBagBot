﻿using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Core.Attributes
{
    public class RequirePermissionsAttribute : PreconditionAttribute
    {
        private readonly PermissionGroup permissionGroup;

        public RequirePermissionsAttribute(PermissionGroup group)
        {
            permissionGroup = group;
        }

        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            if (context.User is SocketGuildUser gUser)
            {
                if (gUser.GuildPermissions.RawValue >= (ulong)permissionGroup)
                    return Task.FromResult(PreconditionResult.FromSuccess());
                else
                    return Task.FromResult(PreconditionResult.FromError($"{context.User.Mention}, у тебя недостаочно прав использовать эту команду."));
            }
            else
                return Task.FromResult(PreconditionResult.FromError("Ты должен быть на сервере чтобы использовать эту команду."));
        }
    }
}
