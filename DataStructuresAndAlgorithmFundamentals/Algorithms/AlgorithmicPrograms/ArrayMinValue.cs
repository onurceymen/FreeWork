namespace Algorithms.AlgorithmicPrograms
{
    public class ArrayMinValue
    {
        public float MinValue(float[] A , int N) 
        {
            int k;
            float ek;
            ek = A[0];
            for (k = 1; k < N; k++)
            {
                if (A[k] < ek)
                {
                    ek = A[k];
                }
            }
            return ek;
        }
    }
}
