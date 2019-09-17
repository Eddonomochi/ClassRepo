
function getAndValidateName() {
    let isValidating = true;
    let name;
    while (isValidating) {
        name = prompt("Hey dude, what is your name?");
        if (/\w{2,}/g.test(name)) {
           isValidating = false;
        } else {
            alert("invalid input");
        }
    }
    alert(`hello ${name}, whats good... no, whats REALLY good?!`);
}

getAndValidateName();