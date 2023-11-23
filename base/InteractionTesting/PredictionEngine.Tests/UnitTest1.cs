using Moq;

namespace PredictionEngine.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

/*

    [Test]
public void Ping_invokes_DoSomething()
{
    // ARRANGE
    var mock = new Mock<ILanguageModelAlgo>();
    mock.Setup(p => p.predictUsingMonogram(It.IsAny<string>())).Returns("value");
   

    // ACT
    

    // ASSERT
    mock.Verify(p => p.predictUsingMonogram("PING"), Times.Once());
}
*/
}