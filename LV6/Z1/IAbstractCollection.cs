using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
