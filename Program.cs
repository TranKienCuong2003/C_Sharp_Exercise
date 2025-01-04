using System;

class Program
{
    static void Main(string[] args)
    {
        // Bài tập chủ đề 1: Các phép toán cơ bản
        Console.WriteLine("Chủ đề 1: Các phép toán cơ bản");
        Basic_Operations.Addition.Run();
        Basic_Operations.Subtraction.Run();
        Basic_Operations.Multiplication.Run();
        Basic_Operations.Division.Run();
        Basic_Operations.Modulus.Run();
        Basic_Operations.Increment.Run();
        Basic_Operations.Decrement.Run();
        Basic_Operations.Power.Run();
        Basic_Operations.Sqrt.Run();
        Basic_Operations.AbsoluteValue.Run();
        Console.WriteLine();

        // Bài tập chủ đề 2: Cấu trúc điều khiển
        Console.WriteLine("Chủ đề 2: Cấu trúc điều khiển");
        Control_Structures.IfElse.Run();
        Control_Structures.SwitchCase.Run();
        Control_Structures.WhileLoop.Run();
        Control_Structures.ForLoop.Run();
        Control_Structures.DoWhileLoop.Run();
        Control_Structures.NestedIfElse.Run();
        Control_Structures.NestedLoops.Run();
        Control_Structures.BreakStatement.Run();
        Control_Structures.ContinueStatement.Run();
        Control_Structures.TernaryOperator.Run();
        Console.WriteLine();

        // Bài tập chủ đề 3: Mảng và các tập hợp
        Console.WriteLine("Chủ đề 3: Mảng và các tập hợp");
        Arrays_and_Collections.declareAndInitializeArray.Run();
        Arrays_and_Collections.accessArrayElements.Run();
        Arrays_and_Collections.arrayLength.Run();
        Arrays_and_Collections.reverseArray.Run();
        Arrays_and_Collections.findMaxElement.Run();
        Arrays_and_Collections.findMinElement.Run();
        Arrays_and_Collections.multidimensionalArray.Run();
        Arrays_and_Collections.jaggedArray.Run();
        Arrays_and_Collections.listInCSharp.Run();
        Arrays_and_Collections.dictionaryInCSharp.Run();
        Console.WriteLine();

        // Bài tập chủ đề 4: Hàm và phương thức
        Console.WriteLine("Chủ đề 4: Hàm và phương thức");
        Functions_and_Methods.simpleFunction.Run();
        Functions_and_Methods.functionWithParameters.Run();
        Functions_and_Methods.functionWithReturn.Run();
        Functions_and_Methods.functionOverloading.Run();
        Functions_and_Methods.recursiveFunction.Run();
        Functions_and_Methods.optionalParameters.Run();
        Functions_and_Methods.anonymousFunction.Run();
        Functions_and_Methods.lambdaExpression.Run();
        Functions_and_Methods.functionReturningArray.Run();
        Functions_and_Methods.passByReference.Run();
        Console.WriteLine();

        // Bài tập chủ đề 5: Lớp và đối tượng
        Console.WriteLine("Chủ đề 5: Lớp và đối tượng");
        Object_Oriented_Programming.DefineClass.Run();
        Object_Oriented_Programming.ContructorInClass.Run();
        Object_Oriented_Programming.Encapsulation.Run();
        Object_Oriented_Programming.Inheritance.Run();
        Object_Oriented_Programming.MethodOverriding.Run();
        Object_Oriented_Programming.Polymorphism.Run();
        Object_Oriented_Programming.Abstraction.Run();
        Object_Oriented_Programming.InterfaceImplementation.Run();
        Object_Oriented_Programming.StaticClass.Run();
        Object_Oriented_Programming.PropertyInClass.Run();
        Console.WriteLine();

        // Bài tập chủ đề 6: Thuật toán
        Console.WriteLine("Chủ đề 6: Thuật toán");
        Algorithms.BubbleSort.Run();
        Algorithms.SelectionSort.Run();
        Algorithms.InsertionSort.Run();
        Algorithms.QuickSort.Run();
        Algorithms.MergeSort.Run();
        Algorithms.BinarySearch.Run();
        Algorithms.LinearSearch.Run();
        Algorithms.HeapSort.Run();
        Algorithms.RadixSort.Run();
        Algorithms.CountingSort.Run();
        Console.WriteLine();

        // Bài tập chủ đề 7: Cấu trúc dữ liệu
        Console.WriteLine("Chủ đề 7: Cấu trúc dữ liệu");
        DataStructures.ArrayImplementation.Run();
        DataStructures.StackImplementation.Run();
        DataStructures.QueueImplementation.Run();
        DataStructures.LinkedListImplementation.Run();
        DataStructures.HashSetImplementation.Run();
        DataStructures.DictionaryImplementation.Run();
        DataStructures.BinarySearchTreeImplementation.Run();
        DataStructures.PriorityQueueImplementation.Run();
        DataStructures.DequeImplementation.Run();
        DataStructures.CircularQueueImplementation.Run();
        Console.WriteLine();

        // Bài tập chủ đề 8: Thuật toán sắp xếp
        Console.WriteLine("Chủ đề 8: Thuật toán sắp xếp");
        SortingAlgorithms.BubbleSort.Run();
        SortingAlgorithms.SelectionSort.Run();
        SortingAlgorithms.InsertionSort.Run();
        SortingAlgorithms.QuickSort.Run();
        SortingAlgorithms.MergeSort.Run();
        SortingAlgorithms.HeapSort.Run();
        SortingAlgorithms.CountingSort.Run();
        SortingAlgorithms.RadixSort.Run();
        SortingAlgorithms.BucketSort.Run();
        SortingAlgorithms.ShellSort.Run();
        Console.WriteLine();

        // Bài tập chủ đề 9: Thuật toán tìm kiếm
        Console.WriteLine("Chủ đề 9: Thuật toán tìm kiếm");
        SearchingAlgorithms.LinearSearch.Run();
        SearchingAlgorithms.BinarySearch.Run();
        SearchingAlgorithms.RecursiveBinarySearch.Run();
        SearchingAlgorithms.FindMinimum.Run();
        SearchingAlgorithms.FindMaximum.Run();
        SearchingAlgorithms.Search2DArray.Run();
        SearchingAlgorithms.HashSetSearch.Run();
        SearchingAlgorithms.LinkedListSearch.Run();
        SearchingAlgorithms.BinaryTreeSearch.Run();
        SearchingAlgorithms.AVLTreeSearch.Run();
        Console.WriteLine();
    }
}
