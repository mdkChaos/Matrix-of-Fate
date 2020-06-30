// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict";


(function () {
    let arr = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'SA', 'SB', 'SC', 'SD', 'SE', 'SF', 'SG'];
    for (let i = 0; i < arr.length; i++) {
        let count = document.getElementById(`C${arr[i]}`).getElementsByTagName('circle').length;
        for (let j = 1; j <= count; j++) {
            WriteText(`C${arr[i]}${j}`, `T${arr[i]}${j}`);
        }
    }
})();

function WriteText(cName, tName) {
    let circle = document.getElementById(cName);
    let x = circle.getAttribute("cx");
    let y = circle.getAttribute("cy");
    let text = document.getElementById(tName);
    let len = text.innerHTML.length;

    if (len == 2) {
        text.setAttribute("x", x - 13);
        text.setAttribute("y", y - 0 + 8);
    }
    else {
        text.setAttribute("x", x - 7);
        text.setAttribute("y", y - 0 + 8);
    }
}