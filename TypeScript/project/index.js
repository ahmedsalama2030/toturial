"use strict";
var canvas = document.querySelector("#mainCanvas");
var ctx = canvas.getContext("2d");
drawTree();
function drawTree() {
    ctx.strokeStyle = "#000";
    node();
    arrowleft();
    arrowRight();
}
function node() {
    ctx === null || ctx === void 0 ? void 0 : ctx.beginPath();
    ctx === null || ctx === void 0 ? void 0 : ctx.arc(canvas.width / 2, 50, 20, 0, 2 * Math.PI);
    ctx.strokeStyle = "#000";
    ctx.fill();
    ctx === null || ctx === void 0 ? void 0 : ctx.stroke();
}
function arrowleft() {
    ctx === null || ctx === void 0 ? void 0 : ctx.beginPath();
    ctx === null || ctx === void 0 ? void 0 : ctx.moveTo(canvas.width / 2, 50);
    ctx === null || ctx === void 0 ? void 0 : ctx.lineTo(300, 90);
    ctx.fill();
    ctx === null || ctx === void 0 ? void 0 : ctx.stroke();
}
function arrowRight() {
    ctx === null || ctx === void 0 ? void 0 : ctx.beginPath();
    ctx === null || ctx === void 0 ? void 0 : ctx.moveTo(canvas.width / 2, 50);
    ctx === null || ctx === void 0 ? void 0 : ctx.lineTo(100, 90);
    ctx.fill();
    ctx === null || ctx === void 0 ? void 0 : ctx.stroke();
}
