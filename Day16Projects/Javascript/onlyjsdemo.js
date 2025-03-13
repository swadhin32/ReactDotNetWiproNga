
function test()
{
console.log("hello world ");
}
test();
function test2(num1, num2)
{
return (num1 + num2);
}
let sum = test2(12, 45);
console.log(sum);
//so above two functions using arrow is like this
const testme = () => console.log("hello world ")
testme();
const test2me = (n1, n2) => n1 + n2;
let sum2 = test2me(10, 34);
console.log(sum2);
//I can write a function where only single value is passing
const test3 = (number) => number + 10;
let sum3 = test3(134);
console.log(sum3);