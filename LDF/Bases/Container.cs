namespace LDF.Bases
{
    public class Container : DeviceBase
    {
        public Container(string Name, DeviceBase DeviceBase, params DeviceBase[] DeviceBases)
            : base(Name)
        {
            GroupTogether(DeviceBase);
            GroupTogether(DeviceBases);
        }

        public Container(string Name, DeviceBase[] DeviceBase)
            : base(Name)
        {
            GroupTogether(DeviceBase);
        }
    }
}
