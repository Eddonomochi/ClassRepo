// VARIABLES

let jamesJackson = "James";
const rob = "Rob";
var ollie = "Ollie";

jamesJackson = 23;


console.log(jamesJackson);

// UNDEFINED VARIABLE
let notJames;

console.log(notJames);

// SHALLOW EQUALITY
let value = "23";
let valueTwo = 23;

if (value == valueTwo) {
    console.log("...wtf");
}

// STRICT EQUALITY
if (value === valueTwo) {
    console.log("thats better");
}


// IF STATEMENTS
let age = 21;

if (age >= 21) {
    alert("you're good");
} else {
    alert ("get outta here kid, you're not welcome!");
}

// FUNCTIONS
function getAge() {
    let age = prompt("How old are you?");
    return age;
}

// FUNCTION WITH PARAMETER
function addNumbers(numOne, numTwo) {
    return numOne + numTwo;
}

console.log(getAge());

console.log(addNumbers(2, 5));

// ARRAYS
let names = [ "James", "Rob", "Vlad" ];

let anyTypeArray = [2, true, "Rob", 33.2]; // DON"T DO THIS

// 2D ARRAY
let shapes = [ [ 1, 2, 3], [1, 2, 3], [1, 2, 3]];

// MAP IS A "DICTIONARY" IN C#, KEY VALUE PAIR
let statesMap = new Map();

statesMap.set("Texas", "large");
statesMap.set("Michigan", "large");

let texas = statesMap.get("Texas");

// SET IS A "HASHSET" IN C#, UNIQUE VALUES
let uniqueNumbers = new Set();

uniqueNumbers.add(1);
uniqueNumbers.add(2);
uniqueNumbers.add(2);
uniqueNumbers.add(3);

// STANDARD FOR LOOP, JUST LIKE C# 
for (let i = 0; i < uniqueNumbers.length; i++) {
    console.log(anyTypeArray[i]);
}

// THIS IS THE SAME AS A FOR EACH LOOP IN C#, FOR OF LOOP
for (const number of uniqueNumbers) {
    console.log(number);
}

// although this looks like a C# forEach loop, this is going to 
// give you the Key in an object, or the index number in an
// array
for (const key in anyTypeArray) {
    console.log(key);
}

// CALL BACK FUNCTIONS
function parentFunction(fn) {
    console.log("this is the parent function");

    fn();
}

function callBackFunction() {
    console.log("I'm a call back function");
}

parentFunction(callBackFunction);

parentFunction(() => {
    console.log("I am an arrow function that is also a call back function");
})

// ARRAY FUNCTIONS

// forEach
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach
names.forEach((n) => {
    console.log(n);
})

// map
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/map
// same as Select() in C#
const doubleNamed = names.map((n) => {
    return `${n} ${n}`;
})

console.log("==============  doubleNamed =============== ");
console.log(doubleNamed)

// filter 
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter
// same as Where() in C#
const filteredJamesNames = names.filter((n) => {
    return n !== "James";
})

console.log("==============  filteredJamesNames =============== ");
console.log(filteredJamesNames)

// some
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/some
// same as Any() in C#
const hasVlad = names.some((n) => {
    return n === "Vlad"
})

console.log("==============  hasVlad =============== ");
console.log(hasVlad)

// reduce
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/Reduce
const reducedNames = names.reduce((prevName, currentName) => {
    return prevName + currentName
}, "");


console.log("==============  reducedNames =============== ");
console.log(reducedNames);

// Classes
class Person {
    name;
    age;
}

let james = new Person();
james.name = "James";
james.age = 30;

let robTwo = new Person();
robTwo.name = "Rob";
robTwo.age = 20;

console.log(robTwo.name);

class Dog {
    constructor(breed, age) {
        this.breed = breed;
        this.age = age;
    }

    barkName() {
        return `bark bark, my breed is ${this.breed}`;
    }
}


let poodle = new Dog("Poodle", 2);

console.log(poodle);
console.log(poodle.barkName());

let pattern = /^name$/g;