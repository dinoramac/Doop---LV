using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z1
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int countColumns = data[0].Length;
            double[] results = new double[countColumns];
            for (int i = 0; i < countColumns; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    results[i] = results[i] + data[j][i];
                }
                int lengthNumber = data.Length;
                results[i] = results[i] / lengthNumber;
            }
            return results;
        }
    }
}
