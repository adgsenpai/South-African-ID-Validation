//app.js

var edtIDNumber = document.getElementById('edtIDNumber');
var storedText;



function done() {
    document.getElementById("Result").innerHTML = "<h5>" + storedText + "</h5>";
}

function processID() {
    var url = "/validateid/" + edtIDNumber.value;
    url = encodeURI(url);
    fetch(url)
        .then(function (response) {
            response.text().then(function (text) {
                storedText = text;
                done();
            });
        });
}

