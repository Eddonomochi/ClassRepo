var form = document.getElementById('list-form');


form.addEventListener('submit', (e) => {
    e.preventDefault();
    
    const listElement = document.getElementById("form-list");

    

    console.log("OUR CAPTURED EXISTING DOM ELEMENT")
    console.log(listElement)

    const inputElement = document.getElementById("user-input");

    const value = inputElement.value;

    const listItem = document.createElement("li");

    console.log("vvv THIS GUY DOES NOT EXIST IN THE DOM YET")
    console.log(listItem);

    listItem.innerText = value;

    console.log("vvv STILL NOT IN THE DOM, BUT HAS INNER TEXT")
    console.log(listItem);

    listElement.appendChild(listItem);

    console.log("vvv OUR LIST ELEMENT THAT EXIST IN THE DOM, NOW HAS AN ADDITIONAL CHILD ELEMENT")
    console.log(listElement);

});


function clickHandler() {

    console.log(document);

    const listElement = document.getElementById("list");

    const children = document.children;

    console.log(JSON.stringify(listElement));

    console.log(children);

    const listItem = document.createElement('li');
    listItem.innerText = "sup";

    listElement.appendChild(listItem);
}




function formHandler(e) {
    e.preventDefault();
}


// jQuery way
const jqueryElement = $("#id");

// javascript way
const element = document.querySelector("#id");


// jQuery event binding
jqueryElement.on("click", (e) => {
    // code here
})


// javascript way
element.addEventListener("click", (e) => {
    // code here
})