// function parentFunction(callBackFunction) {

//     const message = "I am a parameter";

//     console.log("I am the parent function");
//     callBackFunction(message);
// }

// function definedCallBackFunction(message) {
//     console.log("I am the defined call back function" + message);
// }

// parentFunction(definedCallBackFunction);

// parentFunction((m) => {
//     console.log("Traditional callback function" + m);
// });


const hideButton = document.getElementById("hide-btn");

hideButton.addEventListener("click", (e) => {
    e.preventDefault();

    const square = document.getElementById("square");

    if (square.style.display === "none") {
        revealSquare(square);
    } else {
        hideSquare(square)
    }
})

const listButton = document.getElementById("list-btn");

const form = document.getElementById("form");
form.addEventListener("submit", (e) => {
    e.preventDefault();

    const listElement = document.getElementById("list");

    const listItem = document.createElement("li");

    const userInput = document.getElementById("user-input");

    if (userInput.value.length >= 1) {
        listItem.innerText = userInput.value;

        userInput.value = "";

        listElement.appendChild(listItem);
    }

    if (listElement.childElementCount >= 5) {
        listButton.setAttribute("disabled", false);
        listButton.innerText = "TOO MANY ITEMS!!!"
    }
})


function hideSquare(square) {
    square.style.display = "none";
}

function revealSquare(square) {
    square.style.display = "block";
}

hideButton.addEventListener("scroll", (e) => {

})