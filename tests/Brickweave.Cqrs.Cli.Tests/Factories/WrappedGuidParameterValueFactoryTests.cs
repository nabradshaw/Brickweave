﻿using System;
using Brickweave.Cqrs.Cli.Factories;
using Brickweave.Cqrs.Cli.Tests.Models;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Brickweave.Cqrs.Cli.Tests.Factories
{
    public class WrappedGuidParameterValueFactoryTests
    {
        private readonly ITestOutputHelper _output;

        public WrappedGuidParameterValueFactoryTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Qualifies_WhenTypeIsWrappedGuid_ReturnsTrue()
        {
            var factory = new WrappedGuidParameterValueFactory();

            var result = factory.Qualifies(typeof(BarId));

            result.Should().BeTrue();
        }

        [Fact]
        public void Qualifies_WhenTypeIsNotWrappedGuid_ReturnsFalse()
        {
            var factory = new WrappedGuidParameterValueFactory();

            var result = factory.Qualifies(typeof(FooId));

            result.Should().BeFalse();
        }

        [Fact]
        public void Create_WhenTypeIsWrappedGuid_ReturnsWrapperInstance()
        {
            var factory = new WrappedGuidParameterValueFactory();

            var result = factory.Create(typeof(BarId), "{5AB66721-6713-4BDC-94EE-0C8BB28760D6}");

            result.Should().BeOfType<BarId>();
            result.As<BarId>().Value.Should().Be(new Guid("{5AB66721-6713-4BDC-94EE-0C8BB28760D6}"));
        }

        [Fact]
        public void Create_WhenParameterValueIsNotGuid_Throws()
        {
            var factory = new WrappedGuidParameterValueFactory();

            var exception = Assert.Throws<InvalidOperationException>(() => factory.Create(typeof(BarId), 1));

            exception.Should().NotBeNull();
            _output.WriteLine(exception.Message);
        }
    }
}
