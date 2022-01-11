using NSubstitute;

[UsesVerify]
public class Tests
{
    #region ReceivedCalls

    [Fact]
    public Task Test()
    {
        var target = Substitute.For<ITarget>();
        target.Method(1, 2);
        return Verify(target.ReceivedCalls());
    }

    #endregion
}