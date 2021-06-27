import {Queue  } from"../../class/Queue/queue.js"

let arrayData=[5,1,3,7,9,8,12,13,14,15,10,0];

let queue=new Queue();
arrayData.forEach(element => {
     queue.enQueue(element);
});
 


