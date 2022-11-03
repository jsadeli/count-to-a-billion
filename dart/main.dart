void main() {
	print('Hello World!');
  Stopwatch stopwatch = new Stopwatch()..start();

  var i = 0;
  while(i < 1000000000) {
    i++;
  }

  var duration = stopwatch.elapsedMilliseconds;
  print("duration=${duration}ms");
  print("i=${i}");
}
