using Babylon.Ledger.Api.Controllers.v1;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq.AutoMock;

namespace Babylon.Ledger.Api.UnitTests.Controllers.v1;

public class IncomesControllerTests
{
    private readonly AutoMocker autoMocker = new ();

    private readonly IncomesController sut;

    public IncomesControllerTests()
    {
        sut = autoMocker.CreateInstance<IncomesController>();
    }
    
    [Fact]
    public async Task When_Get_Method_Is_Called_Ok_Result_Is_Returned()
    {
        // Act
        var result = await sut.Get();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<OkResult>();
    }
}