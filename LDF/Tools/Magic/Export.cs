using System;
using System.Collections.Generic;
using System.IO;
using LDF.Bases;

namespace LDF.Tools.Magic
{
    public static class Export
    {
        private static int _portIndex = 0;
        private static List<string> _commands = new List<string>();
        private static string _dim = "um";

        public static bool ExportMagic(IReadOnlyList<Box> Boxes, string FilePath)
        {
            for (int i = 0; i < Boxes.Count; i++)
            {
                Box box = Boxes[i];
                paint(box);

                if (box.Port != null)
                {
                    createPort(box);
                }
            }

            using (StreamWriter sw = File.CreateText(FilePath))
            {
                foreach (string command in _commands)
                {
                    sw.WriteLine(command);
                }
            }

            return true;
        }

        private static void createBox(Box box)
        {
            string selectBox = "box values " +
                box.LowerLeft.X + _dim + " " +
                box.LowerLeft.Y + _dim + " " +
                box.UpperRight.X + _dim + " " +
                box.UpperRight.Y + _dim;
            _commands.Add(selectBox);
        }

        private static void paint(Box box)
        {
            if (string.IsNullOrEmpty(box.Layer.Name))
                throw new Exception("Not a valid layer.");

            createBox(box);
            _commands.Add("paint " + box.Layer.Name);
        }

        private static void createPort(Box box)
        {
            createLabel(box, box.Port.Name);
            string cmdCreatePort = "port make " + _portIndex++ + "; " +
                "port class " + Keywords.ClassesNames[box.Port.Class] + "; " +
                "port use " + Keywords.UsesNames[box.Port.Use] + "; " +
                "port shape " + Keywords.ShapesNames[box.Port.Shape] + ";";
            _commands.Add(cmdCreatePort);
        }

        private static void createLabel(Box box, string label, float fontSize = 0.5f)
        {
            createBox(box);
            string cmdCreateLabel = "label " +
                label + " " +
                "FreeSans" + " " +
                fontSize + _dim + " " +
                "0 0um 0um center" + " " +
                box.Layer.Name;
            _commands.Add(cmdCreateLabel);
        }
    }
}
