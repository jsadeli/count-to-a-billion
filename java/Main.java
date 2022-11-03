class Main {
  public static void main(String[] args) {
    System.out.println("Hello World!");
    long start = System.currentTimeMillis();

    // the super hard counting code
    int i = 0;
    while (i < 1_000_000_000) {
      i++;
    }

    long stop = System.currentTimeMillis();
    long duration = stop - start;
    System.out.println(duration + "ms");
    System.out.println("i=" + i);
  }
}
