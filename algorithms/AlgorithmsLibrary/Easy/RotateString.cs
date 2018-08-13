using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class RotateString
    {
        public bool Main(string A, string B)
        {
            if (string.IsNullOrEmpty(A) && string.IsNullOrEmpty(B)) return true;
            if (string.IsNullOrEmpty(A) || string.IsNullOrEmpty(B)) return false;

            foreach (var item in A)
            {
                char temp = A[0];
                A = A.Remove(0, 1);
                A = A.Insert(A.Length, temp.ToString());

                if (A.Equals(B)) return true;
            }

            return false;
        }
    }
}
