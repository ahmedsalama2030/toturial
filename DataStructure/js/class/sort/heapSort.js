


let heapify = (array,length,parentIndex) => {
    let largest = parentIndex;
    let left = (2 * parentIndex )+ 1;
    let right = (2 * parentIndex )+ 2;

    if (left < length && array[left] > array[largest])
      largest = left;

    if (right < length && array[right] > array[largest])
      largest = right;

    // Swap and continue heapifying if root is not largest
    if (largest != parentIndex) {
      let swap = array[parentIndex];
      array[parentIndex] = array[largest];
      array[largest] = swap;

      heapify(array, length, largest);
    }
}
let Heapsort = (array) => {
  const length = array.length;
 // Build max heap
 let start=Math.floor((length/2) - 1);
  for (let i = start; i >= 0; i--) {
     heapify(array, length, i);
 }
// Heap sort
 for (let i = length - 1; i >= 0; i--) {
     let temp = array[0];
     array[0] = array[i];
     array[i] = temp;

     // Heapify root element
     heapify(array, i, 0);
 }
  return array;
}
export{
    Heapsort
}