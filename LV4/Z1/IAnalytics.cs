using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
