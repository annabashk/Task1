using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Estimate(20);

        static void AddList()
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("C:\\Users\\annab\\Downloads\\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var str = new List<string>();

            str.AddRange(words);

            //foreach (var word in str)
            //    Console.WriteLine(word);

            str.Add("qwerty");
        }
       
        static void Estimate(int n)
        {
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < n; i++)
            {
                timer.Restart();

                AddList();

                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
            }
            
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

        static void AddLinkedList()
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("C:\\Users\\annab\\Downloads\\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


        }
    }
}