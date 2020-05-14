using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
