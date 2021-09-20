import { T1 } from "./TsDemoInterface1";
import { T2 } from "./TsDemoInterface2";

function AlternatingStrings(obj1: T1, obj2: T2) {
  let smallerArray: number = Math.min(obj1.stringArray1.length, obj2.stringArray2.length);
  let fullString: string = '';
  for (let i = 0; i < smallerArray; i++){
    fullString += `${obj1.stringArray1[i]} ${obj2.stringArray2[i]}}`
  }

  return fullString;
}

let myObj1: T1 = { stringArray1: ["This", "a", "cool", "demo"], myInt: 100, isBool: true }
let myObj2: T2 = { stringArray2: ["is", "really", "Typescript", "."], myBigInt: 10033333333333333333333333333n, currentDate: new Date() }

let resultString: string = AlternatingStrings(myObj1, myObj2);

console.log(resultString);