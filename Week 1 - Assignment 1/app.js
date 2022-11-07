

let string1 = "";
let string2 = "";
let string3 = "";
let string4 = "";
let string5 = "";

/*

*
**
***
****
*****
******

*/

for (let i = 0; i < 5; i++) {
  for (let j = 0; j < i; j++) {
    string1 += "*";
  }
  string1 += "\n";
}

console.log(string1);

/*

     *
    **
   ***
  ****
 *****
******

*/

for (let i = 0; i < 5; i++) {
  for (let j = 5; j > i; j--) {
    string2 += " ";
  }
  for (let k = 0; k < i; k++) {
    string2 += "*";
  }
  string2 += "\n";
}

console.log(string2);

/*

    *
   ***
  *****
 *******
*********

*/

for (let i = 0; i <= 5; i++) {
  for (let j = 5; j > i; j--) {
    string3 += " ";
  }
  for (let k = 0; k < i * 2 - 1; k++) {
    string3 += "*";
  }
  string3 += "\n";
}

console.log(string3);

/*

*********
 *******
  *****
   ***
    *

*/


for (let i = 5; i >= 0; i--) {
    for (let j = 5; j > i; j--) {
      string4 += " ";
    }
    for (let k = 0; k < i * 2 - 1; k++) {
      string4 += "*";
    }
    string4 += "\n";
  }

  console.log(string4);



  /* 
  
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
  
  */

  for (let i = 0; i <= 5; i++) {
    for (let j = 5; j > i; j--) {
      string5 += " ";
    }
    for (let k = 0; k < i * 2 - 1; k++) {
      string5 += "*";
    }
    string5 += "\n";
  }
  for (let i = 4; i >= 0; i--) {
    for (let j = 5; j > i; j--) {
      string5 += " ";
    }
    for (let k = 0; k < i * 2 - 1; k++) {
      string5 += "*";
    }
    string5 += "\n";
  }
 

  console.log(string5);