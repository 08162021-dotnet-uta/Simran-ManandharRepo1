"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function AlternatingStrings(obj1, obj2) {
    let smallerArray = Math.min(obj1.stringArray1.length, obj2.stringArray2.length);
    let fullString = '';
    for (let i = 0; i < smallerArray; i++) {
        fullString += `${obj1.stringArray1[i]} ${obj2.stringArray2[i]}}`;
    }
    return fullString;
}
let myObj1 = { stringArray1: ["This", "a", "cool", "demo"], myInt: 100, isBool: true };
let myObj2 = { stringArray2: ["is", "really", "Typescript", "."], myBigInt: 10033333333333333333333333333n, currentDate: new Date() };
let resultString = AlternatingStrings(myObj1, myObj2);
console.log(resultString);
