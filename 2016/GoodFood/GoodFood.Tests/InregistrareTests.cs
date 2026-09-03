using FluentAssertions;
using Xunit.Abstractions;

namespace GoodFood.Tests;

public class InregistrareTests
{
    private readonly ITestOutputHelper _output;

    public InregistrareTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void EmailWithSingleAtGetsSplittedIn2Tokens()
    {
        const string email = "ionel@costel   ";
        var tokens = email.Split('@', StringSplitOptions.RemoveEmptyEntries);
        tokens.Should().HaveCount(2);
        
        _output.WriteLine($"#{tokens[0]}#");
        _output.WriteLine($"#{tokens[1]}#");
    }
}

