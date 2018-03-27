using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    public class MatrixProgs
    {
        // Rotate N x N Matrix Counter Clockwise
        // Terminology:
        //   layer = number of cells from edge of matrix
        //   offset = how many cells ccw from corner of layer
        //   side = side of matrix (left = 0, bottom = 1, right = 2, top = 3)

        public static int[,] RotateNxNMatrixCCW(int[,] matrix)
        {
            if(matrix.GetLength(0) != matrix.GetLength(1))
            {
                return null;
            }

            int nLayers = matrix.GetLength(0) / 2;
            int nSides = 4;

            // Offsets into 3rd dimension of offSetCells
            const int y = 0;
            const int x = 1;
            const int value = 2;

            for(int layer=0; layer < nLayers; layer++)
            {
                int nOffsets = matrix.GetLength(0) - 2 * layer - 1;
                int[,,] offsetCells = new int[nOffsets, nSides, 3];

                for(int i=0; i < nOffsets; i++)
                {
                    offsetCells[i, 0, y] = layer + i;
                    offsetCells[i, 0, x] = layer;
                    offsetCells[i, 1, y] = matrix.GetLength(0) - 1 - layer;
                    offsetCells[i, 1, x] = layer + i;
                    offsetCells[i, 2, y] = matrix.GetLength(0) - 1 - layer - i;
                    offsetCells[i, 2, x] = matrix.GetLength(1) - 1 - layer;
                    offsetCells[i, 3, y] = layer;
                    offsetCells[i, 3, x] = matrix.GetLength(1) - 1 - layer - i;
                }

                for(int i=0;i<nOffsets;i++)
                {
                    for(int j=0;j<nSides;j++)
                    {
                        offsetCells[i, j, value] = matrix[offsetCells[i, j, y], offsetCells[i, j, x]];
                    }
                }

                for(int i=0;i<nOffsets;i++)
                {
                    int tempValue = offsetCells[i, nSides - 1, value];
                    for(int j=nSides-1;j>=1;j--)
                    {
                        offsetCells[i, j, value] = offsetCells[i, j - 1, value];  
                    }
                    offsetCells[i, 0, value] = tempValue;
                }

                for(int i=0;i<nOffsets;i++)
                {
                    for(int j=0;j<nSides;j++)
                    {
                        int m = offsetCells[i, j, y];
                        int n = offsetCells[i, j, x];
                        int v = offsetCells[i, j, value];
                        matrix[m, n] = v;
                    }
                }

            }
            return matrix;
        }

        public static int[][] rotate(int[][] matrix, int n)
        {

            for (int layer = 0; layer < n / 2; ++layer)
            {
                int first = layer;
                int last = n - 1 - layer;

                for (int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    int top = matrix[first][i]; // save top

                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    // bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    // top -> right

                    matrix[i][last] = top; // right <- saved top

                }
            }
            return matrix;
        }


    }
}
