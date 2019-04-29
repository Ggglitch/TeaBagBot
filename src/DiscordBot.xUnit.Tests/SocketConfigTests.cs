﻿using DiscordBot.Core;
using Xunit;

namespace DiscordBot.xUnit.Tests
{
    public class SocketConfigTests
    {
        [Fact]
        public void GetDefault_ShouldWork()
        {
            var config = SocketConfigFactory.GetDefault();

            Assert.NotNull(config);
        }

        [Fact]
        public void GetNew_ShouldWork()
        {
            var config = SocketConfigFactory.GetNew();

            Assert.NotNull(config);
        }
    }
}
