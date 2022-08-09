namespace LDF.Bases
{
    public class ExternalPort
    {
        public enum Classes
        {
            input,
            output,
            inout,
            tristate,
            bidirectional,
            feedthrough
        }
        public enum Uses
        {
            analog,
            signal,
            digital,
            power,
            ground,
            clock
        }

        public enum Shapes
        {
            abutment,
            ring,
            feedthrough
        }

        public string Name { get; }
        public Classes Class { get; }
        public Uses Use { get; }
        public Shapes Shape { get; }

        public ExternalPort(string Name, Classes Class, Uses Use, Shapes Shape)
        {
            this.Name = Name;
            this.Class = Class;
            this.Use = Use;
            this.Shape = Shape;
        }
    }

    public class InternalPort : DeviceBase
    {
        public InternalPort(string Name)
            : base(Name)
        {

        }

        public InternalPort(string Name, params Box[] Boxes)
            : base(Name)
        {
            GroupTogether(Boxes);
        }

        public InternalPort(string Name, params DeviceBase[] Devices)
            : base(Name)
        {
            GroupTogether(Devices);
        }
    }
}
