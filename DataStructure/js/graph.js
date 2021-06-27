
import { BinaryTree,   NodeTree } from"./class/Graph/BuildBinaryTree.js"
// initial
let rootNode=new NodeTree(7);
let binaryTree= new BinaryTree(rootNode);
let arrauhtml=[]
 
let getArray=(arr)=>{
    let arrNew=[];
    for (let index = 0; index < arr.length; index++) {
        arrNew.push(`<span class="p-1 text-bold d-inline-block bg-success m-1 text-white">${arr[index]}</span>`)
        
    }
    return arrNew;
}
// add node;
let arrayData=[1,3,7,9,8,12,13,14,15,10,0];
for (let index = 0; index < arrayData.length; index++) {
    arrauhtml.push(arrayData[index])
    binaryTree.addNode(new NodeTree(arrayData[index]),rootNode);
}
let result=binaryTree.search(8,rootNode);
let dbfSerch=binaryTree.SearchDBF(65,rootNode);
console.log(dbfSerch);

 document.querySelector("#source").innerHTML=getArray(arrauhtml).join(' ');
 
 
 document.querySelector("#search-btn").addEventListener("click",(e)=>{
    document.querySelector("#result").innerHTML="";
     let text=parseInt( document.querySelector("#textSearch").value);
      let result=binaryTree.search(text,rootNode);
      if(result)
       document.querySelector("#result").innerHTML="found";
       else
       document.querySelector("#result").innerHTML="not found";

     })
 
     document.cookie = "cookiename=fg; expires= Thu, 21 Aug 2022 20:00:00 UTC";