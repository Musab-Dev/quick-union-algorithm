namespace QuickUnionAlgorithm
{
	public class WeightedQuickUnion : IQuickUnion
    {
		int[] Objects { get; set; }
        int[] Sizes { get; set; }

		public WeightedQuickUnion(int NumberOfObjects)
		{
			Objects = new int[NumberOfObjects];
            Sizes = new int[NumberOfObjects];

			for (int i = 0; i < NumberOfObjects; i++)
			{
				Objects[i] = i;
                Sizes[i] = 1;
			}
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

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public int Root(int ObjectNumber)
        {
            int i = ObjectNumber;

            while (i != Objects[i])
            {
                i = Objects[i];
            }

            return i;
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

