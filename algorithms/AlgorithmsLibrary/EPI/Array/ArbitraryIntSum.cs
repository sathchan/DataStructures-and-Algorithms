namespace AlgorithmsLibrary
{
    /*
        Arbitrary Sum
        -------------

        Example1:
        Input = {1, 2, 9}
        Output = {1, 3, 0}

        Example2:
        Input = {9, 9}
        Output = {1, 0, 0}
     */

    public class ArbitraryIntSum
    {
        public int[] Main(int[] A)
        {
            if (A == null || A.Length == 0) return A;
            int arrLength = (A[0] == 9) ? A.Length + 1 : A.Length;
            int[] Acopy = new int[arrLength];
            int carry = 1;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                int temp = A[i] + carry;
                carry = temp / 10;
                Acopy[i] = temp % 10;
            }

            if (A[0] == 9) Acopy[0] = carry;

            return Acopy;
        }
    }
}
