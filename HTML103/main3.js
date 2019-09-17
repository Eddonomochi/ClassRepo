function clickHandler() {
    const listElement = document.getElementById("list");

    const listItem = document.createElement('li');
    listItem.innerText = "sup";

    listElement.appendChild(listItem);
}