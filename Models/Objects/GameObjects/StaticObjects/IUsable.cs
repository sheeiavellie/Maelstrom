using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects
{
    internal interface IUsable
    {
        int Row { get; set; }
        int Column { get; set; }
        void Use(dynamic p);
    }
}
