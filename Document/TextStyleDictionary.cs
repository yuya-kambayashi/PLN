using BaseCAD.Graphics;

namespace BaseCAD
{
    public class TextStyleDictionary : PersistableDictionaryWithDefault<TextStyle>
    {
        public TextStyleDictionary() : base("0", TextStyle.Default)
        {
            ;
        }
    }
}
