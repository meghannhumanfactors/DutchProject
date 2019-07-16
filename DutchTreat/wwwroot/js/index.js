//var x = 0;
//var s = "";
//alert("Hello Pluralsight");
//console.log("Hello Purlasight");
//-------------------------------------------------------------------------------
//Hides the form
// this is to hide it in JavaScript
//var theForm = document.getElementById("theForm");
//theForm.hidden = true;


//Hides the form with JQuery
//var theForm = $("#theForm");
//theForm.hide();
//--------------------------------------------------------------------------------
//Button JavaScript
//var button = document.getElementById("buyButton");
//button.addEventListener("click", function () {
//    console.log("Buying Item");
//});

var theForm = $("#theForm");

//JQuery
var button = $("#buyButton");
button.on("click", function () {
    console.log("Buying Item");
});
//------------------------------------------------------------------------------

//JavaScript

//var productInfo = document.getElementsByClassName("product-props");
//var listItems = productInfo.item[0].children;

//Jquery
var productInfo = $(".product-props li");
productInfo.on("click", function () {
    console.log("You clicked on one of the items: " + $(this).text());
});

var $loginToggle = $("#loginToggle");
var $popupForm = $(".popup-form");

$loginToggle.on("click", function () {
    $popupForm.toggle(1000);
});

});
