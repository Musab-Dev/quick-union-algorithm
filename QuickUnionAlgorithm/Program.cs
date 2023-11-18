using QuickUnionAlgorithm;

Console.Write("What algorithm you want to use?\n" +
    "1- Union Find Algorithm.\n" +
    "2- Weighted Union Find Algorithm.\n" +
    "AnyOtherNumber- Weighted Union Find Algorithm With Path Compression.\n" +
    "Enter the number: ");
int algoChoice = Convert.ToInt32(Console.ReadLine());

Console.Write("Define the number of objects: ");
int number = Convert.ToInt32(Console.ReadLine());

IQuickUnion algorithm;
if (algoChoice == 1)
{
    algorithm = new QuickUnion(number);
}
else if (algoChoice == 2)
{
    algorithm = new WeightedQuickUnion(number);
}
else
{
    algorithm = new WeightedQuickUnionPathCompression(number);
}

int choice;
do
{
    Console.Write("choose the desired operation:\n" +
        "1- Connect 2 objects.\n" +
        "2- Check the connectivity between 2 objects.\n" +
        "3- Print the Objects Array.\n" +
        "4- Find the largest element in Component.\n" +
        "5- Quit.\n" +
        "Enter the number: ");
    choice = Convert.ToInt32(Console.ReadLine());

    int p, q;
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the two numbers:");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            algorithm.Union(p, q);
            break;
        case 2:
            Console.WriteLine("Enter the two numbers:");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            if (algorithm.Connected(p, q))
            {
                Console.WriteLine($"Objects {p} and {q} are connected.");
            }
            else
            {
                Console.WriteLine($"Objects {p} and {q} are NOT connected.");
            }
            break;
        case 3:
            algorithm.Print();
            break;
        case 4:
            Console.Write("Enter the number: ");
            int objectNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the largest element in the component containing {objectNumber} is {algorithm.Find(objectNumber)}");
            break;
        case 5:
            Console.WriteLine("==============================\n" +
                "Thank You...");
            break;
        default:
            Console.WriteLine("please select one of the previous choices.");
            break;
    }
} while (choice != 5);