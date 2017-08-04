using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SParseMatrix
{
    public class SParse
    {
        static int row = 1000;
        static int col = 1000;
        int[,] traditionalMatrix = new int[row,col];

        public bool CreateTraditionalMatrix()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    traditionalMatrix[i, j] = 0;
                }
            }

            traditionalMatrix[999, 3] = 5;
            traditionalMatrix[500, 999] = 6;
            traditionalMatrix[800, 3] = 7;
            traditionalMatrix[99, 312] = 8;
            traditionalMatrix[100, 400] = 9;
            return true;
        }


        public int[,] CreateSParseSir()
        {
            int size = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (traditionalMatrix[i,j]!=0)
                    {
                        size++;
                    }
                }
            }

            int[,] SParseMatrix = new int[3, size];

            int k = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (traditionalMatrix[i,j]!=0)
                    {
                        SParseMatrix[0, k] = i;
                        SParseMatrix[1, k] = j;
                        SParseMatrix[2, k] = traditionalMatrix[i, j];
                        k++;
                    }
                }
            }
            
            return SParseMatrix;
        }

        public int[,] CreateSParseMy()
        {
            int size = 0;

            int[,] SParseMatrixTemp = new int[3, row * col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (traditionalMatrix[i,j]!=0)
                    {
                        SParseMatrixTemp[0, size] = i;
                        SParseMatrixTemp[1, size] = j;
                        SParseMatrixTemp[2, size] = traditionalMatrix[i, j];
                        size++;
                    }
                }
            }
            
            int[,] SParseMatrix = new int[3, size];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    SParseMatrix[i, j] = SParseMatrixTemp[i, j];
                }
            }
            return SParseMatrix;
        }
    }
}
