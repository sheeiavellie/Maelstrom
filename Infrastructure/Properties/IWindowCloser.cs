using System;
using System.Windows.Input;

namespace Maelstrom.Infrastructure.Properties
{
    internal interface IWindowCloser
    {
        Action Close { get; set; }
        bool CanClose { get; }
    }
}
