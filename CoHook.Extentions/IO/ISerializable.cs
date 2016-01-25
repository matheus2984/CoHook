namespace CoHook.Extentions.IO
{
    public interface ISerializable
    {
        void Serialize(BinaryOutput output);
        ISerializable Deserialize(BinaryInput input);
    }
}