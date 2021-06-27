class sort {

    constructor(source) {
       
        this.source = source;
 
    }
    // BubbleSort  ///////////////////////////////////////
    BubbleSort() {
        
        console.log(this.source);
        let arrlength=this.source.length;
        let count=0;
        for (let outer = 0; outer < arrlength; outer++) {
             for (let inner = 1; inner < arrlength-outer; inner++) {
                count++;
                  if(parseInt( this.source[inner-1]) >parseInt(this.source[inner])){
                        let temp=this.source[inner-1];
                        this.source[inner-1]=this.source[inner];
                        this.source[inner]=temp;
                 }
                
            }
            
        }
        console.log(this.source);

        return { count: count, result: this.source }
    }
        //end  BubbleSort///////////////////////////////////////////////////


}
export{
    sort
}