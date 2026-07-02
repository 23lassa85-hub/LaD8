Queue<string> queue = new Queue<string>();
Random rand = new Random();
int n = rand.Next(5, 10);
for (int i = 0; i < n; i++)
{
    string surname = "Иванов" + i;
    double avg = rand.Next(30, 60) / 10.0;
    queue.Enqueue(surname + " " + avg.ToString("F1"));
}
foreach (string s in queue) Console.Write(s + " ");
Console.WriteLine();
Console.Write("Фамилия нового студента: ");
string newSurname = Console.ReadLine();
Console.Write("Средний бал: ");
double newAvg = double.Parse(Console.ReadLine());
queue.Enqueue(newSurname + " " + newAvg.ToString("F1"));
Console.WriteLine("Очередь после добавления:");
foreach (string s in queue) Console.Write(s + " ");
Console.WriteLine();
