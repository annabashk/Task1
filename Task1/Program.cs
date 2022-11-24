using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // читаем весь файл с рабочего стола в строку текста
        string text = File.ReadAllText("C:\\Users\\annab\\Downloads\\Text1.txt");

        // cохраняем символы-разделители в массив
        char[] delimiters = new char[] { ' ', '\r', '\n' };

        // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        Estimate(10, words);

        static void AddList(string[] words)
        {
            List<string> str = new List<string>(words);

            str.Add("qwerty");
        }

        static void AddLinkedList(string[] words)
        {
            LinkedList<string> str = new LinkedList<string>(words);

            str.AddLast("qwerty");
        }

        static void Estimate(int n, string[] words)
        {
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < n; i++)
            {
                timer.Restart();

                AddList(words);

                timer.Stop();
                Console.WriteLine($"List:{timer.ElapsedMilliseconds}");

                timer.Restart();

                AddLinkedList(words);

                timer.Stop();
                Console.WriteLine($"LinkedList:{timer.ElapsedMilliseconds}");
            }
        }
    }
}