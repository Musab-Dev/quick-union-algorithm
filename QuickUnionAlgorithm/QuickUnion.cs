namespace QuickUnionAlgorithm
{
	public class QuickUnion : IQuickUnion
    {
		private int[] Objects { get; set; }

		public QuickUnion(int NumberOfObject)
		{
            Objects = new int[NumberOfObject];

			for (int i = 0; i < NumberOfObject; i++)
			{
                Objects[i] = i;
			}
		}

		public void Union(int p, int q)
		{
			int pRoot = Root(p);
			int qRoot = Root(q);
            Objects[pRoot] = qRoot;
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

