using Newtonsoft.Json;
using NSubstitute.Core;

class CallConverter :
    WriteOnlyJsonConverter<ICall>
{
    public override void Write(VerifyJsonWriter writer, ICall value, JsonSerializer serializer)
    {
        var target = new
        {
            Method = value.GetMethodInfo(),
            Arguments = value.GetArguments(),
        };
        serializer.Serialize(writer, target);
    }
}