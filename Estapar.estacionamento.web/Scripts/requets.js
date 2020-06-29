

function get(url, funcCallBack) {
    $.getJSON(url, {
        format: "json"
    }).done(function (data) {
        funcCallBack(data);
        return data;
    }).fail(function (jqxhr, textStatus, error) {
        var err = textStatus + ", " + error;
        console.log("Request Failed: " + err);
        return null;
    });
}