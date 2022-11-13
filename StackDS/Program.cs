// simple stack

System.Collections.Stack simpleStack = new();

simpleStack.Push("Hello");
simpleStack.Push("World");
simpleStack.Push("!");

Console.WriteLine("simpleStack");
Console.WriteLine("\t count = {0}", simpleStack.Count);
Console.WriteLine("\t values is ");

PrintValues(simpleStack);

static void PrintValues(System.Collections.IEnumerable simplecollection)
{
    foreach(object o in simplecollection)
    {
        Console.WriteLine(" {0}", o);
    }

    Console.WriteLine();
}