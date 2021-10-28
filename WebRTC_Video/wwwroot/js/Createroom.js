"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/ConnectionHub").build();

connection.start();

connection.on("showroom", function (Room) {
    var ul = document.getElementById("messagesList")
    var li = document.createElement("li");
    li.innerHTML = `<div style="border: 0.1 solid;">
    <a href="call/${Room}">${Room}</a>
     <i class=" fa fa-video-camera"></i>
    <div>`;
    ul.append(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.


});

document.getElementById("btnCreateroom").addEventListener("click", function (event) {
    var Room = document.getElementById("txtroom").value;
    connection.invoke("CreateRoom", Room).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});