using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventControlHandler
{
    public class ElementEventHandler
    {
        public string ElementName { get; set; }
        public string ElementValue { get; set; }
        public double ScrollX { get; set; }
        public double ScrollY { get; set; }
        public ElementType ElementType { get; set; }
        public string ToUserId { get; set; }
        public bool IsExpert { get; set; }
    }
    public enum ElementType
    {
        TextBox,
        Button,
        ScroolView
    }
}
