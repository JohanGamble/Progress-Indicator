var progressInvocationProxy = $.connection.progressTaskHub;
progressInvocationProxy.client.sendServerData = function (message) {
    var progressbar = $("#progressbar"), progressLabel = $(".progress-label"), progressPercent = $(".progress-percent");
    progressbar.progressbar({
        value: message.Completed,
        change: function () {
            progressPercent.text(message.Percent + "%");

            console.log(message.Percent)
        },
        complete: function () {
            progressLabel.text(message.Status);
        }
    });
}

$.connection.hub.start()
    .done(function () {
        console.log("Connection established");
        progressInvocation();
    })
    .fail(function () {
        console.log("Connection failed!");
    });

function progressInvocation() {
    $('#sendMessage').click(function () {
        progressInvocationProxy.server.send();
    })
}

function invokeMethod() {
    $.post("/Home/InvokeCounterMethod/", { "value": 1000 })
}