using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maelstrom.Models.Indicators
{
    internal class UnitUnderPlayerControl
    {
        public int Position { get; set; }
        public string Type { get; set; }
        public UnitUnderPlayerControl(string Type)
        {
            this.Type = Type;
        }
    }
}
