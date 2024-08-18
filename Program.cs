namespace ParallelExamples.Invoke.For.Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Parallel.Invoke

            //Parallel.Invoke(
            //   () => Console.WriteLine($"Action 1 on thread {Task.CurrentId}"),
            //   () => Console.WriteLine($"Action 2 on thread {Task.CurrentId}"),
            //   () => Console.WriteLine($"Action 3 on thread {Task.CurrentId}")
            // );

            //Console.WriteLine("All actions completed.");
            #endregion

            #region Parallel.For

            //Parallel.For(0, 10, i =>
            //{
            //    Console.WriteLine($"Processing {i} on thread {Task.CurrentId}");
            //});
            //Console.WriteLine("All iterations completed.");

            #endregion

            #region Parallel.ForEach

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Parallel.ForEach(numbers, number =>
            //{
            //    Console.WriteLine($"Processing {number} on thread {Task.CurrentId}");
            //});
            //Console.WriteLine("All items processed.");

            #endregion

            #region LoopState
            //Parallel.For(0, 100, (i, loopState) =>
            //{
            //    Console.WriteLine($"Processing {i} on thread {Task.CurrentId}");

            //    if (i == 1)
            //    {
            //        Console.WriteLine("Breaking loop...");
            //        loopState.Break(); // Breaks the loop after completing the current iteration
            //    }
            //});

            //Console.WriteLine("Loop completed.");
            #endregion
        }
    }
}
