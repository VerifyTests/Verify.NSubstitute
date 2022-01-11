﻿using Newtonsoft.Json;
using NSubstitute.Core;

class CallConverter :
    WriteOnlyJsonConverter<ICall>
{
    public override void WriteJson(
        JsonWriter writer,
        ICall value,
        JsonSerializer serializer,
        IReadOnlyDictionary<string, object> context)
    {
        var target = new
        {
            Method = value.GetMethodInfo(),
            Arguments = value.GetArguments(),
        };
        serializer.Serialize(writer, target);
    }
}