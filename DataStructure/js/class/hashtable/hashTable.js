"use strict";
 
 class HashTable {
    constructor(size) {
        this.mainArray = new Array(size);
        for (let index = 0; index < this.mainArray .length; index++) {
            this.mainArray [index]={key:index,value:0,next:null}
            
        }
    }
    GetHash(key) {
         
        let x= key % (this.mainArray.length);
     
        return x;

    }
    Add(key , value) {
        let node={key,value}
        let index = this.GetHash(node.key);
        let dataIndex = this.mainArray[index];
         
        node.next = dataIndex.next;
        dataIndex.next = node;
        return node;
    }
search(key){
    let hash=this.GetHash(key);
    let index=this.mainArray[hash];
     let result=null;
    while(index !=null)
    {
       if(index.key===key){
       result= index;
        break ;
        }
        else{
      index=index.next;
        }
        
    }
    return result;

}

    Print() {
        for (let index = 0; index < this.mainArray.length; index++) {
            console.log(this.mainArray[index]);
        }
    }
}
export{
      HashTable
    
}
