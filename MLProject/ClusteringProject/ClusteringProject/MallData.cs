using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;

namespace ClusteringProject
{
    public class MallData
    {
        [LoadColumn(3)]
        public float AnnualIncome;

        [LoadColumn(4)]
        public float SpendingScore;

    }

    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
}
