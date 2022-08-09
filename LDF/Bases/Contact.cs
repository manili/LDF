using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases
{
    public class Contact : DeviceBase
    {
        public Contact(string Name, Box BaseBox,
            Layer LowerLayer, Layer ContactLayer, Layer UpperLayer, Directions Direction,
            Size LowerLayerSize, Size ContactLayerSize, Size UpperLayerSize, ExternalPort Port = null)
            : base(Name)
        {
            Point origin = new Point(0.0f, 0.0f);

            Box lowerLayer = new Box(origin, LowerLayerSize, LowerLayer, null);
            lowerLayer.AlignWith(BaseBox, Direction);
            Box contactLayer = new Box(origin, ContactLayerSize, ContactLayer, null);
            contactLayer.AlignWith(lowerLayer, Directions.Center);
            Box upperLayer = new Box(origin, UpperLayerSize, UpperLayer, Port);
            upperLayer.AlignWith(lowerLayer, Directions.Center);

            GroupTogether(lowerLayer, contactLayer, upperLayer);
        }
    }
}
