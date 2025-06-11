using System;

public class Solution {
    public int[] solution(int[,] arr) {
        int n = arr.GetLength(0);
        return Compress(arr, 0, 0, n);
    }

    private int[] Compress(int[,] arr, int row, int col, int size) {
        if (IsUniform(arr, row, col, size)) {
            int value = arr[row, col];
            return value == 0 ? new int[] { 1, 0 } : new int[] { 0, 1 };
        }

        int half = size / 2;
        int[] topLeft = Compress(arr, row, col, half);
        int[] topRight = Compress(arr, row, col + half, half);
        int[] bottomLeft = Compress(arr, row + half, col, half);
        int[] bottomRight = Compress(arr, row + half, col + half, half);

        return new int[] {
            topLeft[0] + topRight[0] + bottomLeft[0] + bottomRight[0],
            topLeft[1] + topRight[1] + bottomLeft[1] + bottomRight[1]
        };
    }

    private bool IsUniform(int[,] arr, int row, int col, int size) {
        int baseValue = arr[row, col];
        for (int i = row; i < row + size; i++) {
            for (int j = col; j < col + size; j++) {
                if (arr[i, j] != baseValue) return false;
            }
        }
        return true;
    }
}
