internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (0-999):");
        string input = Console.ReadLine();
        
        // Kiểm tra đầu vào
        if (int.TryParse(input, out int number) && number >= 0 && number <= 999)
        {
            string result = ConvertNumberToWords(number);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Out of ability");
        }
    }

    static string ConvertNumberToWords(int number)
    {
        if (number == 0) return "zero";
        
        string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string words = "";

        // Bước 5: Đọc các số có ba chữ số
        if (number >= 100)
        {
            int hundreds = number / 100;
            words += ones[hundreds] + " hundred";
            number %= 100;
            if (number > 0) words += " and ";
        }

        // Bước 3: Đọc các số có hai chữ số nhỏ hơn 20
        if (number >= 10 && number < 20)
        {
            words += teens[number - 10];
        }
        else
        {
            // Bước 4: Đọc các số có hai chữ số lớn hơn hoặc bằng 20
            if (number >= 20)
            {
                int tensPlace = number / 10;
                words += tens[tensPlace];
                number %= 10;
                if (number > 0) words += " ";
            }
            // Bước 2: Đọc các số có một chữ số
            if (number > 0 && number < 10)
            {
                words += ones[number];
            }
        }

        return words;

    }
}

