let expression = "3.5 +4*10-5.3 /5 =";
console.log(eval(expression.split("=").join("")));

const d = Function("return " + expression.split("=").join(""))();

console.log(d)
