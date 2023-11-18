This repository is done as a practice during Algorithm Part 01 course introduced by Princeton University on Coursera. 

# Quick Union Algorithm

This C# project implements the Quick Union algorithm along with its variations, namely Weighted Quick Union and Weighted Quick Union with Path Compression. These algorithms are used for solving the dynamic connectivity problem, where the goal is to efficiently determine whether two objects are connected within a set of objects.

## QuickUnion

The `QuickUnion` class implements the basic Quick Union algorithm.

### Constructor

```csharp
public QuickUnion(int NumberOfObject)
```

Creates a QuickUnion object with the specified number of objects, initializing each object to be in its own connected component.

### Methods

- **Union(int p, int q)**: Connects the components containing objects `p` and `q`.
- **Connected(int p, int q)**: Checks if objects `p` and `q` are connected.
- **Root(int ObjectNumber)**: Finds the root of the component to which the object belongs.
- **Print()**: Prints the current state of the objects and their connections.
- **Find(int objectNumber)**: Finds the largest element in the connected component containing the specified object.

## WeightedQuickUnion

The `WeightedQuickUnion` class implements the Weighted Quick Union algorithm, which optimizes the union operation by considering the size of the connected components.

### Constructor

```csharp
public WeightedQuickUnion(int NumberOfObjects)
```

Creates a WeightedQuickUnion object with the specified number of objects, initializing each object to be in its own connected component.

### Methods

- **Union(int p, int q)**: Connects the components containing objects `p` and `q`, taking into account the component sizes.
- **Connected(int p, int q)**: Checks if objects `p` and `q` are connected.
- **Root(int ObjectNumber)**: Finds the root of the component to which the object belongs.
- **Print()**: Prints the current state of the objects and their connections.
- **Find(int objectNumber)**: Finds the largest element in the connected component containing the specified object.

## WeightedQuickUnionPathCompression

The `WeightedQuickUnionPathCompression` class extends Weighted Quick Union by incorporating path compression, which further optimizes the `Root` method by flattening the tree structure.

### Constructor

```csharp
public WeightedQuickUnionPathCompression(int NumberOfObjects)
```

Creates a WeightedQuickUnionPathCompression object with the specified number of objects, initializing each object to be in its own connected component.

### Methods

- **Union(int p, int q)**: Connects the components containing objects `p` and `q`, taking into account the component sizes.
- **Connected(int p, int q)**: Checks if objects `p` and `q` are connected.
- **Root(int objectNumber)**: Finds the root of the component to which the object belongs with path compression.
- **Print()**: Prints the current state of the objects and their connections.
- **Find(int objectNumber)**: Finds the largest element in the connected component containing the specified object.

## Usage

You can use these classes to efficiently determine connectivity and perform union operations on sets of objects. Feel free to explore the provided methods and integrate them into your applications as needed.

## Getting Started

To use this implementation in your C# project, simply clone the repository and incorporate the `QuickFind.cs` file into your project.

```bash
git clone https://github.com/Musab-Dev/quick-find-algorithm.git
```

## Contributing

If you find any issues, have improvements, or want to contribute to this project, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
