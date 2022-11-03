#include <iostream>
#include <chrono>
using namespace std::chrono;

int main() {
  std::cout << "Hello World!\n";
  auto start = high_resolution_clock::now();

  // the super hard counting code
  int i = 0;
  while (i < 1000000000) {
    i++;
  }

  auto stop = high_resolution_clock::now();
  auto duration = duration_cast<microseconds>(stop - start);
  std::cout << "duration: " << duration.count() << " ms\n";
  std::cout << "i=" << i << "\n";
}
