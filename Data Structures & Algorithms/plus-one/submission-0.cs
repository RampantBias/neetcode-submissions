public class Solution {
    public int[] PlusOne(int[] digits) {
        int remainder = 1;
        int index = digits.Length - 1;
        while (index >= 0 && remainder > 0) {
            if (digits[index] == 9) {
                digits[index] = 0;
            } else {
                digits[index] += remainder;
                remainder = 0;
            }
            index--;
        }
        if (remainder > 0) {
            int[] resizedResult = new int[digits.Length + 1];
            resizedResult[0] = 1;
            return resizedResult;
        }
        return digits;
    }
}
