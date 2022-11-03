Module HelloWorld
	Sub Main()
    System.Console.WriteLine("Hello VB!")
    Dim watch As Stopwatch = Stopwatch.StartNew()
    watch.Start()

    Dim i As Integer = 0
    While i < 1_000_000_000
      i += 1
    End While

    watch.Stop()
    System.Console.WriteLine("duration (ms): " + CStr(watch.Elapsed.TotalMilliseconds))
    System.Console.WriteLine("i=" + CStr(i))
	End Sub
End Module
