namespace BaseCAD
{
    public class LayerDictionary : PersistableDictionaryWithDefault<Layer>
    {
        public LayerDictionary() : base("0", Layer.Default)
        {
            ;
        }
    }
}
