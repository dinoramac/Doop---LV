using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
