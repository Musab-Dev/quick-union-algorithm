using System;
namespace QuickUnionAlgorithm
{
	public class WeightedQuickUnionPathCompression : IQuickUnion
    {
        int[] Objects { get; set; }
        int[] Sizes { get; set; }

        public WeightedQuickUnionPathCompression(int NumberOfObjects)
        {
            Objects = new int[NumberOfObjects];
            Sizes = new int[NumberOfObjects];

            for (int i = 0; i < NumberOfObjects; i++)
            {
                Objects[i] = i;
                Sizes[i] = 1;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Print()
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < Objects.Length; i++)
            {
                Console.Write($"{Objects[i]}\t");
            }
            Console.WriteLine();
        }

        public int Root(int objectNumber)
        {
            int i = objectNumber;

            while (i != Objects[i])
            {
                // make the node points to its grandparnt (shorten the path by 1/2)
                Objects[i] = Objects[Objects[i]];

                i = Objects[i];
            }

            // Another Option is to make every examined node points to the root (using a second loop) 

            return i;
        }

        public void Union(int p, int q)
        {
            int pRoot = Root(p);
            int qRoot = Root(q);

            if (pRoot == qRoot) return;
            if (Sizes[pRoot] < Sizes[qRoot])
            {
                Objects[pRoot] = qRoot;
                Sizes[qRoot] += Sizes[pRoot];
            }
            else
            {
                Objects[qRoot] = pRoot;
                Sizes[pRoot] += Sizes[qRoot];
            }
        }

        public int Find(int objectNumber)
        {
            int largestElementInComponent = objectNumber;

            for (int i = 0; i < Objects.Length; i++)
            {
                if (Connected(objectNumber, i))
                {
                    if (i > largestElementInComponent)
                    {
                        largestElementInComponent = i;
                    }
                }
            }

            return largestElementInComponent;
        }
    }
}

