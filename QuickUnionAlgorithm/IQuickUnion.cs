namespace QuickUnionAlgorithm
{
	public interface IQuickUnion
	{
		void Union(int p, int q);
		bool Connected(int p, int q);
		int Root(int objectNumber);
		void Print();
		int Find(int objectNumber);
    }
}

