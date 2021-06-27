import {Search} from"./class/search/linearsearch.js"

//
//initial souce array
var SourceArray=[];
const Max=100;
for (let index = 0; index < Max; index++) {
    let text=  index;
    SourceArray[index]=text;
  let node=  document.createElement('li');
  let nodetext=document.createTextNode(text);
  node.appendChild(nodetext);
     
    document.querySelector("#menu-search").appendChild(node );
}
var  SearchObj=new Search(SourceArray);
/// end
// search btn 
 document.querySelector("#search-btn").addEventListener( "click",(e)=>{
let searchText=document.querySelector("#search-text").value;

   let resultSearch=SearchObj.serachLinear(searchText);
   let binarySearch=SearchObj.binarySearch(searchText);
   let interSearch=SearchObj.interpolationSearch(searchText);
document.querySelector("#linear-result").innerText =(resultSearch.result)?"found":" not found";
document.querySelector("#linear-count").innerText =resultSearch.count;
document.querySelector("#binary-result").innerText =(binarySearch.result)?"found":" not found";
document.querySelector("#binary-count").innerText =binarySearch.count;
document.querySelector("#inter-result").innerText =(interSearch.result);
document.querySelector("#inter-count").innerText =interSearch.count;
 
})


// end