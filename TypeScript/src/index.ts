 let canvas=document.querySelector("#mainCanvas") as HTMLCanvasElement;
  let  ctx = canvas.getContext("2d");
   drawTree();

function drawTree() {
  ctx!.strokeStyle="#000";

  node();
   arrowleft();
   
   arrowRight();
   

 }
 function  node(){
  ctx?.beginPath();
  ctx?.arc(canvas.width/2, 50, 20, 0, 2 * Math.PI);
  
 ctx!.strokeStyle="#000";

   ctx!.fill();
  ctx?.stroke();
 

 }
 function  arrowleft(){
  ctx?.beginPath();
  ctx?.moveTo(canvas.width/2,50)
  ctx?.lineTo(300,90);
  ctx!.fill();

   ctx?.stroke();
 }
 function  arrowRight(){
  ctx?.beginPath();
  ctx?.moveTo(canvas.width/2,50)
  ctx?.lineTo(100,90);
  ctx!.fill();
  ctx?.stroke();
 }