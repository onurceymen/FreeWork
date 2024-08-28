namespace Algorithms.AlgorithmicPrograms
{
    public class GeometricMean
    {
        public static float CalculateGeometricMean(int[] A, int N)
        {
            int carpim = 1;
            float ort;
            for (int K = 0; K < N; K++)
            {
                carpim *= A[K];
            }
            return (float)Math.Pow(carpim, 1.0 / N);
        }
    }
}
