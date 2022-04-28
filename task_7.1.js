const readline = require("readline");
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});
rl.on("line", (line) => {
  let tempArr = line.split(" ");

  tempArr.forEach((element) => {
    element = element.split("").sort();
    for (let i = 0; i < element.length - 1; i++) {
      if (element[i] === element[i + 1]) {
        line = line.split(element[i]).join("");
      }
    }
  });

  console.log(line);
  process.stdin.unref();
});
