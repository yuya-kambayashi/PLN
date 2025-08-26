namespace BaseCAD
{
    public interface IPersistable
    {
        void Load(DocumentReader reader);
        void Save(DocumentWriter writer);
    }
}
