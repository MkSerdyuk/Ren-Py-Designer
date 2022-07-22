using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ren_Py_Designer
{
    public class LabelStart : CommandBlock
    {

        public string Name { get; private set; }

        public LabelStart(string labelName)
        {
            Name = labelName;
        }

        public LabelStart()
        {
            Keyword = "label";
        }
    }

}