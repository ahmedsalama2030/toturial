 
 let  merge=(left,right)=>{
    let result=[];
    while(left.length&&right.length){
        result.push(left[0] > right[0] ? right.shift() : left.shift());
    }
      return [...result,...left,...right];
}
function MergeSort(array) {
    
    const half = array.length / 2
     // Base case or terminating case
    if(array.length < 2){
      return array 
    }
    
    const left = array.splice(0, half);
    let arr_left=MergeSort(left);
    let arr_right=MergeSort(array);
    
    return merge(arr_left ,arr_right)
  }

export{
    MergeSort  
}