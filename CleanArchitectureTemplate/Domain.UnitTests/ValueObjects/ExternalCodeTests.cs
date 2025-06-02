using Domain.ValueObjects;
using FluentAssertions;
using NUnit.Framework;

namespace Domain.UnitTests.ValueObjects;

public class ExternalCodeTests
{
    [Test]
    public void ShouldBeEqualWhenSystemAndIdMatch()
    {
        var a = new ExternalCode("s1", "1");
        var b = new ExternalCode("s1", "1");

        a.Should().Be(b);
    }
}
