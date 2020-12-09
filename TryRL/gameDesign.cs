using System;
using Raylib_cs;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public class gameDesign
    {
        public string name = "";
        public string color = "";
        public bool goL = true;
        public bool goR = true;
        public bool goU = true;
        public bool goD = true;
        public bool hover = true;
        public bool swap = true;
        public bool show = true;
        public int nr = 0;
        public int posX = 0;
        public int posY = 0;
        public int width = 0;
        public int height = 0;
    }
}
