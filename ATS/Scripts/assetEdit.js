$(document).ready(function () {

});


//$(document).ready(function () {
  
//    $("#financebtn").click(function () {
//        var url = "/AssetEntry/GetPartial";
//        $("#partialDiv").toggle();
//    });
//});
$(document.body).on("click", "#financebtn", function () {
    var url = "/AssetEntry/GetPartial";
    $.get(url, function (responseData) {
        $("#partialDiv").html(responseData);
    });
});

$(document.body).on("click", "#servicebtn", function () {
    $("#partialDiv").hide();
    console.log("alert");
    var url = "/AssetEntry/GetServicePartial";
    $.get(url, function (responseData) {
        $("#servicePartialDiv").html(responseData);
    });
});

$(document.body).on("click", "#attachmentbtn", function () {
   
    var url = "/AssetEntry/GetAttachmentPartial";
    $.get(url, function (responseData) {
        $("#attachmentPartialDiv").html(responseData);
    });
});

$(document.body).on("click", "#notesbtn", function () {
    
    var url = "/AssetEntry/GetNotesPartial";
    $.get(url, function (responseData) {
        $("#notesPartialDiv").html(responseData);
    });
});

$(document.body).on("click", "#historybtn", function () {
    
    var url = "/AssetEntry/GetHistoryPartial";
    $.get(url, function (responseData) {
        $("#historypartialDiv").html(responseData);
    });
});