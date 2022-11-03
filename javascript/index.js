console.log("Hello World!");
console.time("count");

// the super hard counting code
var i = 0;
while (i < 1_000_000_000) {
  i++;
}

console.timeEnd("count");
console.log("i=" + i);
