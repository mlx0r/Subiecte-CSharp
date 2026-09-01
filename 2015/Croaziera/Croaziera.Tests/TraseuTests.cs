using Croaziera;
using FluentAssertions;

namespace Croaziera.Tests;

public class TraseuTests
{
    [Fact]
    public void ShouldGenerateProperlyFor3Days()
    {
        // arrange
        // sut - system under test
        var sut = new Traseu();
        // act
        var result = sut.GenerareTraseu(1, 3);
        // assert
       
        result.Should().BeEquivalentTo([1, 2, 3, 1]);
    }

    [Fact]
    public void ShouldThrowForInvalidTripDays()
    {
        // arrange
        var sut = new Traseu();

        // act
        var calculareTraseu = () => sut.GenerareTraseu(1, 0);

        calculareTraseu.Should().Throw();
        //bool hasThrown = false;
        //try
        //{
        //    var result = sut.GenerareTraseu(1, 3);
        //}
        //catch (Exception)
        //{
        //    hasThrown = true;
        //}
        //hasThrown.Should().BeTrue();
    }
}
