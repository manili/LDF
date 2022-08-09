using System;
using LDF.Bases;
using static Sky130.Constraint;

namespace Sky130
{
    public class Resistor : DeviceBase
    {
        public enum Type
        {
            R0P35,
            R0P69,
            R1P41,
            R2P83,
            R5P73
        }

        public Resistor(string Name, Type Type = Type.R0P35, float Length = 0.5f)
            : base(Name)
        {
            //if (Length < 0.5f)
            //    throw new Exception("Minimum possible length for xpolyres is 500nm");

            //float contactLength = 2.16f;
            //Box xpolyres, res, contactTop, contactBottom;

            //switch (Type)
            //{
            //    case Type.R0P35:
            //        xpolyres = new Box(0.0f, 0.0f, 0.35f, Length, Layers.xpolyres);
            //        res = new Box(0.0f, 0.0f, 0.35f, Length, Layers.res0p35);
            //        contactTop = new Box(0.0f, 0.0f, 0.35f, contactLength, Layers.xpolycontact);
            //        contactBottom = new Box(0.0f, 0.0f, 0.35f, contactLength, Layers.xpolycontact);
            //        break;
            //    case Type.R0P69:
            //        xpolyres = new Box(0.0f, 0.0f, 0.69f, Length, Layers.xpolyres);
            //        res = new Box(0.0f, 0.0f, 0.35f, Length, Layers.res0p69);
            //        contactTop = new Box(0.0f, 0.0f, 0.69f, contactLength, Layers.xpolycontact);
            //        contactBottom = new Box(0.0f, 0.0f, 0.69f, contactLength, Layers.xpolycontact);
            //        break;
            //    case Type.R1P41:
            //        xpolyres = new Box(0.0f, 0.0f, 1.41f, Length, Layers.xpolyres);
            //        res = new Box(0.0f, 0.0f, 0.35f, Length, Layers.res1p41);
            //        contactTop = new Box(0.0f, 0.0f, 1.41f, contactLength, Layers.xpolycontact);
            //        contactBottom = new Box(0.0f, 0.0f, 1.41f, contactLength, Layers.xpolycontact);
            //        break;
            //    case Type.R2P83:
            //        xpolyres = new Box(0.0f, 0.0f, 2.83f, Length, Layers.xpolyres);
            //        res = new Box(0.0f, 0.0f, 0.35f, Length, Layers.res2p85);
            //        contactTop = new Box(0.0f, 0.0f, 2.83f, contactLength, Layers.xpolycontact);
            //        contactBottom = new Box(0.0f, 0.0f, 2.83f, contactLength, Layers.xpolycontact);
            //        break;
            //    case Type.R5P73:
            //        xpolyres = new Box(0.0f, 0.0f, 5.73f, Length, Layers.xpolyres);
            //        res = new Box(0.0f, 0.0f, 0.35f, Length, Layers.res5p73);
            //        contactTop = new Box(0.0f, 0.0f, 5.73f, contactLength, Layers.xpolycontact);
            //        contactBottom = new Box(0.0f, 0.0f, 5.73f, contactLength, Layers.xpolycontact);
            //        break;
            //    default:
            //        xpolyres = new Box(0.0f, 0.0f, 0.35f, Length, Layers.xpolyres);
            //        res = new Box(0.0f, 0.0f, 0.35f, Length, Layers.res0p35);
            //        contactTop = new Box(0.0f, 0.0f, 0.35f, contactLength, Layers.xpolycontact);
            //        contactBottom = new Box(0.0f, 0.0f, 0.35f, contactLength, Layers.xpolycontact);
            //        break;
            //}

            //res = res.AlignWith(xpolyres, Directions.Center);
            //contactTop = contactTop.AlignWith(xpolyres, Directions.Top);
            //contactBottom = contactBottom.AlignWith(xpolyres, Directions.Bottom);
            //GroupTogether(xpolyres, res, contactTop, contactBottom);
        }
    }
}
