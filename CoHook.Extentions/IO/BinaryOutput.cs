using System;
using System.Collections.Generic;
using System.IO;

namespace CoHook.Extentions.IO
{
    public class BinaryOutput : BinaryWriter
    {
        public BinaryOutput(Stream stream) : base(stream)
        {
        }

        public override void Write(char value)
        {
            byte data = Convert.ToByte(value);
            Write(data);
        }

        public void Write(ISerializable value)
        {
            value.Serialize(this);
        }
        public void Write<T>(List<T> value) where T : ISerializable
        {
            Write(value.Count);
            for (var i = 0; i < value.Count; i++)
            {
                value[i].Serialize(this);
            }
        }
    }
}