namespace LDF.Bases.MOSFET
{
    public class MOSFETType
    {
        public string Name { get; set; }

        public Layer Poly { get; set; }
        public Layer Diffusion { get; set; }
        public Layer Tap { get; set; }
        public Layer Transistor { get; set; }

        public Layer PolyContact { get; set; }
        public Layer DiffusionContact { get; set; }
        public Layer TapContact { get; set; }
        public Layer LocalInterconnectContact { get; set; }

        public Layer LocalInterconnect { get; set; }
        public Layer Metal1 { get; set; }

        public Layer Substrate { get; set; }
    }
}
