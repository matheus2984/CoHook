using CoHook.Extentions.IO;

namespace CoHook.Database
{
    public class DbConfig:ISerializable
    {
        public string ConquerDirectory { get; set; }
        public bool Effects { get; set; }

        public void Serialize(BinaryOutput output)
        {
            output.Write(ConquerDirectory);
            output.Write(Effects);
        }

        public ISerializable Deserialize(BinaryInput input)
        {
            ConquerDirectory = input.ReadString();
            Effects = input.ReadBoolean();
            return this;
        }
    }
}
