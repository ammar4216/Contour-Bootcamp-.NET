// Conditional Statements

// Comparison & Logical Operators

let num1 = document.querySelector(".num1");
let num2 = document.querySelector(".num2");
let num3 = document.querySelector(".num3");
let num4 = document.querySelector(".num4");
let result = document.querySelector(".result");
let btn = document.querySelector(".res-btn");

btn.addEventListener("click", () => {
  let number1 = parseInt(num1.value);
  let number2 = parseInt(num2.value);
  let number3 = parseInt(num3.value);
  let number4 = parseInt(num4.value);

  if (number1 > number2 && number1 > number3 && number1 > number4) {
    result.innerHTML = `${number1} is greater than ${number2}, ${number3}, ${number4}`;
  } else if (number2 > number1 && number2 > number3 && number2 > number4) {
    result.innerHTML = `${number2} is greater than ${number1}, ${number3}, ${number4}`;
  } else if (number3 > number1 && number3 > number2 && number3 > number4) {
    result.innerHTML = `${number3} is greater than ${number1}, ${number2}, ${number4}`;
  } else if (number4 > number1 && number4 > number2 && number4 > number3) {
    result.innerHTML = `${number4} is greater than ${number1}, ${number2}, ${number3}`;
  } else {
    result.innerHTML = `${number1}, ${number2}, ${number3}, ${number4} all are equal`;
  }
});

// Even & Odd

let num1Int = prompt("Enter First Number");

if (num1Int % 2 == 0) {
  console.log("The Number is Even");
} else {
  console.log("The number is Odd");
}

// Foor Loop

let str = "bootcamp";
let count = 0;

for (let i = 0; i < str.length; i++) {
  if (str[i] == "o") {
    count++;
  }
}
console.log(count);

// Reverse the String

let name = prompt("Enter the String: ")
let resultString = "";

for (let i = name.length - 1; i >= 0; i--) {
  resultString = resultString + name[i];
}

console.log(resultString);


// Palindrome

if(name === resultString){
    console.log("This is a Palindrome String");
} else{
    console.log("This is not a Palindrome String");
}

// Space Count & Space Remove

let string = "Ammar Ahmed Bootcamp .NET Techlift";
let count2 = 0;

for(let i = 0; i <= string.length; i++)
{
    if(string[i] == " "){
        count2++;
    }
}

let spaceRemove = [...string];

console.log("Spaces in this String: ", count2)
console.log(spaceRemove);
