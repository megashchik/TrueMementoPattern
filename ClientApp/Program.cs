
TrueMemento.Ordinator ordinator = new TrueMemento.Ordinator();

ExternalStorage.Caretaker caretaker = new ExternalStorage.Caretaker();

Console.WriteLine("Start init");
Console.WriteLine(ordinator);
Console.WriteLine();
ExternalStorage.IMemento firstMemento = ordinator.Save("First");
caretaker.Save(firstMemento);

ordinator.Change();
Console.WriteLine("Ordinator was changed");
Console.WriteLine(ordinator);
Console.WriteLine();
ExternalStorage.IMemento secondMemento = ordinator.Save("Second");
caretaker.Save(secondMemento);

ordinator.Change();
Console.WriteLine("Was changed again");
Console.WriteLine(ordinator);
Console.WriteLine();

var mementoFromStorage = caretaker.Undo();
Console.WriteLine($"Memento: {mementoFromStorage.Name}\t{mementoFromStorage.DateTime.Ticks}");
ordinator.Load(mementoFromStorage);
Console.WriteLine("Previous state");
Console.WriteLine(ordinator);
Console.WriteLine();

ExternalStorage.IMemento secondMementoFromStorage = caretaker.Undo();
Console.WriteLine($"Memento: {secondMementoFromStorage.Name}\t{secondMementoFromStorage.DateTime.Ticks}");
ordinator.Load(secondMementoFromStorage);
Console.WriteLine("The first state");
Console.WriteLine(ordinator);
