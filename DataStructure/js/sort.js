import {sort} from"./class/sort/sort.js"
import {MergeSort} from"./class/sort/mergeSort.js"
import {Heapsort} from"./class/sort/heapSort.js"

//
//initial souce array
let SourceArray=[];
let arrauhtml=[]
const Max=51;
for (let index = 0; index < Max; index++) {
    let text= Math.floor(Math.random() * Max)
      SourceArray[index]=text;
     arrauhtml.push(`<span class="p-1 text-bold d-inline-block bg-info m-1 text-white">${text}</span>`)
     
 }
  document.querySelector("#original-source").innerHTML=arrauhtml.join('');

/// end
// search btn 
 document.querySelector("#sort-btn").addEventListener( "change",(e)=>{
    document.querySelector("#result-sort").innerHTML='';
   let type=e.target.value;
    switch(type){
       case 'bubble':
       BubbleSort();
       break;
       case 'merge':
        mergeSort();
        break;
        case 'heap':
         heapSort();
        break;

   }
  

  
 
 
})


let getArray=(arr)=>{
    let arrNew=[];
    for (let index = 0; index < arr.length; index++) {
        arrNew.push(`<span class="p-1 text-bold d-inline-block bg-success m-1 text-white">${arr[index]}</span>`)
        
    }
    return arrNew;
}

let BubbleSort=()=>{
 
     let  sortObj=new sort([...SourceArray]);
    let resultSearch=sortObj.BubbleSort();
     document.querySelector("#result-sort").innerHTML= getArray(resultSearch.result).join('');
}
let mergeSort=()=>{
 
     let resultSearch= MergeSort([...SourceArray]) ;
   document.querySelector("#result-sort").innerHTML= getArray(resultSearch).join('');
     
}
let heapSort=()=>{
    let resultSearch= Heapsort([...SourceArray]) ;
    document.querySelector("#result-sort").innerHTML= getArray(resultSearch).join('');
}



// end