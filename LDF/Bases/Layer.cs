using System.Collections.Generic;

namespace LDF.Bases
{
    public class Layer
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public float MinWidth { get; set; }
        public float MinLength { get; set; }
        public float MinArea { get; set; }

        //Overhang Something
        public Dictionary<uint, float> MinExtension { get; set; }
        //Outside Something
        public Dictionary<uint, float> MinSpacing { get; set; }
        //Inside Something
        public Dictionary<uint, float> MinEnclosure { get; set; }

        public Layer()
        {
            Name = null;
        }
    }
}
