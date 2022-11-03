// Array
let start = document.querySelector(".start");
let end = document.querySelector(".end");
let btn = document.querySelector(".btn-submit");
let res = document.querySelector(".fruitName");
let fruitList = document.querySelector(".fruitList");
  

let arr = [
  "Apple",
  "Mango",
  "Banana",
  "PineApple",
  "Apricot",
  "Avocados",
  "Blueberry",
];

btn.addEventListener("click", () => {

 
  let startValue = parseInt(start.value); 
  let endValue = parseInt(end.value);
  
  console.log(startValue);
  console.log(endValue);

  for (let i = startValue; i < endValue; i++) {
    let li = document.createElement("li");
    let textNode = document.createTextNode(arr[i]);
    li.appendChild(textNode); 
    res.appendChild(li); 
  }                       
 
});



// Map

arr.map((val, i)=>{
  let li = document.createElement("li");
    let textNode = document.createTextNode(arr[i]);
    li.appendChild(textNode); 
    fruitList.appendChild(li); 
});