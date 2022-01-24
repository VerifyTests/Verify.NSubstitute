using NSubstitute.Core;

class CallConverter :
    WriteOnlyJsonConverter<ICall>
{
    public override void Write(VerifyJsonWriter writer, ICall value)
    {
        var target = new
        {
            Method = value.GetMethodInfo(),
            Arguments = value.GetArguments(),
        };
        writer.Serialize(target);
    }
}