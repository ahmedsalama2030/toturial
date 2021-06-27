
import {Node,linkedList} from"../../class/linkedlist/linked.js";


 let linked=new linkedList({value:1,next:null});

linked.Add({value:2,next:null})
linked.Add({value:3,next:null})
linked.Add({value:4,next:null})
linked.Add({value:5,next:null})
 linked.Add({value:6,next:null})
 
 console.log("+".repeat(10))
 linked.Display();

 linked.Add({value:8,next:null})
 linked.Add({value:9,next:null})
 linked.Add({value:10,next:null})

 console.log("+".repeat(10))
 linked.Display();