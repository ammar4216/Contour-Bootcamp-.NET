// Calculator

// Topics Covered in this Example:
// 1. DOM Manipulation
// 2. Operators
// 3. Variables
// 4. Conditional Statement (if else)

const num1 = document.querySelector(".num1");
const num2 = document.querySelector(".num2");
const btn = document.querySelector(".add-btn");
const op = document.querySelector("#op");
const res = document.querySelector(".result");

btn.addEventListener("click", calculator);

function calculator() {
  let result;
  let number1 = parseInt(num1.value);
  let number2 = parseInt(num2.value);
  if (op.value == "add") {
    result = number1 + number2;
  } else if (op.value == "sub") {
    result = number1 - number2;
  } else if (op.value == "mul") {
    result = number1 * number2;
  } else if (op.value == "divide") {
    result = number1 / number2;
  } else if (op.value == "rem") {
    result = number1 % number2;
  } else {
    result = null;
  }

  res.innerHTML = result;
}

// Reverse an Array

// Topics Covered in this Example:
// 5. Loops (for, while)
// 6. Array
// 7. Functions
const bef = document.querySelector(".before");
const aft = document.querySelector(".after");

function reverseArray(arr) {
  let res = [];
  let len = arr.length;
  let j = len;

  for (let i = 0; i < len; i++) {
    res[j - 1] = arr[i];
    j = j - 1;
  }

  return res;
}

const arr = [2, 5, 15, 72, 88, 100];

bef.innerHTML = "Array Before Reversed: " + arr;
aft.innerHTML = "Array After Reversed: " + reverseArray(arr);

// Area of Rectangle

// Topics Covered in this Example:
// 8. Function Expressions / Function Variables (like delegates in C#)

const areaOfRectangle = document.querySelector(".area");
const len = document.querySelector(".len");
const width = document.querySelector(".width");
const areaBtn = document.querySelector(".area-btn");

const getRecArea = () => {
  let area = parseInt(len.value) * parseInt(width.value);
  areaOfRectangle.innerHTML = "Result: " + area;
};

areaBtn.addEventListener("click", getRecArea);
