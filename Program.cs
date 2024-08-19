namespace ParallelExamples.Invoke.For.Foreach
{
    internal class Program
    {
        static void Process(int i)
        {
            Console.WriteLine($"Processing task ({i}) on thread : {Task.CurrentId}");
        }
        static void Main(string[] args)
        {

            #region Parallel.Invoke

            //Parallel.Invoke(
            //   () => Process(1),
            //   () => Process(2),
            //   () => Process(3)
            // );

            //Console.WriteLine("All actions completed.");
            #endregion

            #region Parallel.For

            //Parallel.For(0, 10, i =>
            //{
            //    Process(i);
            //});
            //Console.WriteLine("All iterations completed.");

            #endregion

            #region Parallel.ForEach

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Parallel.ForEach(numbers, number =>
            //{
            //    Process(number);
            //});
            //Console.WriteLine("All items processed.");

            #endregion

            #region LoopState
            //Parallel.For(0, 1000, (i, loopState) =>
            //{
            //    Process(i);

            //    if (i == 2)
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
