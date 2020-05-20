using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
