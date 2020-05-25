// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function giveEvents() {
    var images = document.getElementsByClassName("imagePreview");
    for (var i = 0; i < images.length; i++) {
        images[i].addEventListener("mouseover", function (event) {
            this.style.width = "30vw";
            this.style.position = "absolute";
            console.log("over");
        });
        images[i].addEventListener("mouseout", function (event) {
            this.style.width = "5vw";
            this.style.position = "static";
            console.log("off");
        });

    }
}

giveEvents();
