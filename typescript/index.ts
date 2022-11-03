const s: string = "hello world!";
console.log(s);
console.time("count");

var i = 0;
while (i < 1_000_000_000) {
  i++;
}

console.timeEnd("count");
console.log("i=" + i);
