using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_15._05
{
    public class Matrix
    {
        public int[,] matrix;
        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public Matrix()
        {
            this.matrix = new int[,]{ { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        }
        public static Matrix operator +(Matrix a, Matrix b) 
        {
            Matrix ans = new Matrix();
            for (int i = 0; i < b.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < b.matrix.GetLength(1); j++)
                {
                    ans.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return ans;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix ans = new Matrix();
            for (int i = 0; i < b.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < b.matrix.GetLength(1); j++)
                {
                    ans.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }
            return ans;
        }
        public static Matrix operator *(Matrix a, int c)
        {
            Matrix ans = new Matrix();
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    ans.matrix[i, j] = a.matrix[i, j] * c;
                }
            }
            return ans;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            return a.matrix == b.matrix;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return a.matrix != b.matrix;
        }
        public override bool Equals(Object obj)
        {
            if (obj is Matrix isMatrix) 
            {
                return isMatrix.matrix == this.matrix;
            }
            return false;
        }
        public void Print()
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
