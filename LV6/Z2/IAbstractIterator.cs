using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
