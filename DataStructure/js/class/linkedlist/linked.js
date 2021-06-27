
 class Node{

    constructor(value,next=null){
        this.value=value;
        this.next=next;
    }
 }

 class linkedList{
     constructor(node){
         this.head=node;
      }

      Add(newNode){
        newNode.next=this.head;
        this.head=newNode;
      }

      Delete(){
     this.head=this.head?.next;
       }

      Display(){
        let Temphead=this.head;
          while(Temphead!=null){
            console.log(Temphead.value)
            console.log(Temphead)
            console.log("#".repeat(10))
            Temphead=Temphead.next;

          }
      }
 }

 export{
    linkedList,
        Node
 }