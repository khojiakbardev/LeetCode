/*
 * LettCode - 26
string s = "Let's take LeetCode contest";
Console.WriteLine(ReverseWords(s));

static string ReverseWords(string s)
{
    string[] array = s.Split(new char[] { ' ' });
    string answer = "";
    for (int i = 0; i<array.Length; i++)
    {
        for (int j = array[i].Length - 1; j >= 0; j--)
        {
            answer += array[i][j];
        }
        if(i== array.Length - 1)
        answer += "" ;
    }

    return answer;
}
*/
/*
            int num;
            Console.WriteLine("100 dan 199 gacha bo'lgan oraliqda sonlarni kirit:");
            num = int.Parse(Console.ReadLine());
            if (num < 100 || num > 199)
            {
                Console.WriteLine("Faqat 100 dan 199 gacha oraliqda sonlarni kirit.");
                return;
            }
            string[] units = { "","bir", "ikki", "uch", "to'rt", "besh", "olti", "yetti", "sakkiz", "to'qqiz" };
            string[] tens = { "" ,"O`n", "Yigirma", "O`ttiz", "Qirq", "Ellik", "Otmish", "Yetmish", "Sakson", "To`qson" };
            int hundreds = num / 100;
            int remainder = num % 100;
            Console.Write(units[hundreds] + " yuz");
            if (remainder > 0)
            {
                Console.Write(" ");
                if (remainder < 20)
                {
                    Console.Write(units[remainder]);
                }
                else
                {
                    int tensDigit = remainder / 10;
                    int unitsDigit = remainder % 10;
                    Console.Write(tens[tensDigit] + " " + units[unitsDigit]);
                }
            }*/
namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

        } 
    }
}

