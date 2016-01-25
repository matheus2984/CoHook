using System.Collections.Generic;
using System.IO;

namespace CoHook.Extentions.IO
{
    public class BinaryInput : BinaryReader
    {

        public BinaryInput(Stream stream) : base(stream)
        {
        }

        public T ReadObject<T>() where T : ISerializable, new()
        {
            ISerializable value = new T();
            value.Deserialize(this);

            return (T) value;
        }
        public List<T> ReadList<T>() where T : ISerializable, new()
        {
            int count = ReadInt32();
            var result = new List<T>();

            for (var i = 0; i < count; i++)
            {
                result.Add(ReadObject<T>());
            }

            return result;
        }
    }
}