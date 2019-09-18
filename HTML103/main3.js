var form = document.getElementById('list-form');


form.addEventListener('submit', (e) => {
    e.preventDefault();
    
    const listElement = document.getElementById("form-list");
    const inputElement = document.getElementById("user-input");

    const value = inputElement.value;

    const listItem = document.createElement("li");
    listItem.innerText = value;

    listElement.appendChild(listItem);

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