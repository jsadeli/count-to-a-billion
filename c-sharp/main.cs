using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Hello World!");
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();

    // the super hard counting code
    int i = 0;
    while (i < 1_000_000_000) {
      i++;
    }
    watch.Stop();

    Console.WriteLine($"duration: {watch.ElapsedMilliseconds}ms");
    Console.WriteLine("i=" + i);
  }
}
