"use strict";

const SIGNALR_TOPIC = "DeviceCreated";

// preparing connection to SignalR Hubs
var chatConnection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
var pubSubConnection = new signalR.HubConnectionBuilder().withUrl("/pubSubHub").build();

// starting connection to SignalR Hubs
document.getElementById("btn_send").disabled = true;
chatConnection.start().then(function () {
    document.getElementById("btn_send").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});
document.getElementById("btn_subscribe").disabled = true;
pubSubConnection.start().then(function () {
    document.getElementById("btn_subscribe").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

// action that actually updates DOM upon async receival of data from SignalR Hub
chatConnection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("ul_messages").appendChild(li);
    li.innerHTML = `<b>${user} says</b> <i>${message}</i>`;
});
pubSubConnection.on(SIGNALR_TOPIC, function (arg1) {
    var li = document.createElement("li");
    document.getElementById("ul_pubsub").appendChild(li);
    li.innerHTML = `arg1: <b>${arg1}</i>`;
});

// button listener to send data to SignalR Hub
document.getElementById("btn_send").addEventListener("click", function (event) {
    var user = document.getElementById("txt_user").value;
    var texto = document.getElementById("txt_body").value;
    chatConnection.invoke("SendMessage", user, texto).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
document.getElementById("btn_subscribe").addEventListener("click", function (event) {
    pubSubConnection.invoke("Subscribe", SIGNALR_TOPIC).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});