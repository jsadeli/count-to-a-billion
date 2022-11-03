fun main(args: Array<String>) {
  println("Hello World!")
  val start = System.currentTimeMillis()

  // the super hard counting code
  var i = 0
  while (i < 1_000_000_000) {
    i++
  }

  val stop = System.currentTimeMillis()
  val duration = stop - start
  println("${duration}ms")
  println("i=${i}")
}
