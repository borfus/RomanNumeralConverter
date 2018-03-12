public class RomanNumeralConverter
{
    public string Convert(int num)
    {
        string[] romanNums = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] decimalNums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string finalRomanNum = "";

        for (var i = 0; i < decimalNums.Length; i++)
        {
            while (decimalNums[i] <= num)
            {
                finalRomanNum += romanNums[i];
                num -= decimalNums[i];
            }
        }

        return finalRomanNum;
    }
}