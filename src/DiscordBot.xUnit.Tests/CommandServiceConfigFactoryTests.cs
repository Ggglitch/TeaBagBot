﻿using DiscordBot.Core.Factories;
using Xunit;

namespace DiscordBot.xUnit.Tests
{
    public class CommandServiceConfigFactoryTests
    {
        [Fact]
        public void GetDefault_ShouldNotReturnNull()
        {
            var config = CommandServiceConfigFactory.GetDefault();

            Assert.NotNull(config);
        }

        [Fact]
        public void GetNew_ShouldNotReturnNull()
        {
            var config = CommandServiceConfigFactory.GetNew();

            Assert.NotNull(config);
        }
    }
}
