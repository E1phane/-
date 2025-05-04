public class Solution {
    public int[] solution(int brown, int yellow) {
        int total = brown + yellow;

        for (int height = 3; height <= total / 3; height++) {
            if (total % height != 0) continue;

            int width = total / height;

            if (width < height) continue;

            int yellowArea = (width - 2) * (height - 2);

            if (yellowArea == yellow) {
                return new int[] { width, height };
            }
        }

        return new int[] { };
    }
}
