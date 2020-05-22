// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


function showPreview(id, x, y) {

    var images = document.getElementsByClassName("imagePreview");
    for (var i = 0; i < images.length; i++) {
        if (images[i].id == id) {
            images[i].style.display = "block";
            images[i].style.top = y + "px";
            images[i].style.left = x + "px"
        }
    }
    return;
}


function hidePreview(id) {

    var images = document.getElementsByClassName("imagePreview");
    for (var i = 0; i < images.length; i++) {
        if (images[i].id == id) {
            images[i].style.display = "none";
        }
    }
    return;
}

function giveEvents() {
    var elements = document.getElementsByClassName("Hoverable");
    for (var i = 0; i < elements.length; i++) {
        elements[i].addEventListener("mouseover", function (event) {
            showPreview(this.id, event.clientX, event.clientY);
            console.log(event.clientX + "  " + event.clientY);
            console.log("hover" + " " + this.id);
        });
        elements[i].addEventListener("mouseout", function (event) {
            hidePreview(this.id);
        })
    }
}

giveEvents();

