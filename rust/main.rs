fn main() {
  println!("Hello, world!");
  use std::time::Instant;
  let start = Instant::now();

  let mut i = 0;
  while i < 1_000_000_000 {
    i += 1;
  }

  let duration = start.elapsed();
  println!("duration {:.2?}", duration);
  println!("i={i}");
}
