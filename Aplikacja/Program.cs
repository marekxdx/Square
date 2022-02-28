using Aplikacja;

Console.WriteLine("Welcome in store. You pay 20zł for square meter");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Write number of meters");
int meters = int.Parse(Console.ReadLine()); 
Square [] squares = new Square [meters];

for (int i = 0; i < meters; i++)
{
    squares [i] = new Square (i + 1);
    Console.WriteLine($"Lenght of site is {squares[i].Side} and square is {squares[i].Area}. The payments is {squares[i].Surface} zł");
}

