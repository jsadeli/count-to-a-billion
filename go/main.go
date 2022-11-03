package main

import (
    "fmt"
    "strconv"
    "time"
)

func main() {
    fmt.Println("Hello World!")
    start := time.Now()
    i := 0

    // the super hard counting code
    for i < 1_000_000_000 {
        i++
    }

    end := time.Since(start)
    fmt.Println(end)
  fmt.Println("i=" + strconv.Itoa(i))
}
