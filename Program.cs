Console.WriteLine("Add First:");
LinkedList addedAtStart = new LinkedList();

addedAtStart.AddFirst(1);
addedAtStart.AddFirst(2);
addedAtStart.AddFirst(3);
addedAtStart.AddFirst(4);

addedAtStart.PrintNodes();

Console.WriteLine();
Console.WriteLine("Add Last:");
LinkedList addedAtEnd = new LinkedList();

addedAtEnd.AddLast(1);
addedAtEnd.AddLast(2);
addedAtEnd.AddLast(3);
addedAtEnd.AddLast(4);

addedAtEnd.PrintNodes();

Console.WriteLine();
Console.ReadLine();