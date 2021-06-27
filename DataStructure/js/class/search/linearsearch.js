
class Search {

    constructor(source) {
       
        this.source = source;
        
    }
    serachLinear(saerchText) {
        let resultSearch = false;
        let countSearch = 0;
        
        for (let i = 0; i < this.source.length; i++) {
              if ( saerchText == this.source[i]) {
                resultSearch = true;
                break;
            }
            else{
                countSearch++;
            }
           }

        return { count: countSearch, result: resultSearch }
    }


    binarySearch(saerchText) {
        let resultSearch = false;
        let binarySearch = 0;
        

        let low = 0;
        let high = this.source.length - 1;
        while (low <= high) {
            let mid = parseInt(low + Math.floor((high - low) / 2));
 
             binarySearch++;
             let res = parseInt(saerchText) > parseInt(this.source[mid]);
             let equal =  parseInt(saerchText) == (parseInt(this.source[mid]));
             
            if (equal === true) {
                resultSearch = true;
                break;
            }
            else if (res === true){
                low = mid + 1;
                

            }

            else{
            high = mid - 1; 
            }

        }
         return { count: binarySearch, result: resultSearch }
    }
    interpolationSearch(saerchText) {
        let resultSearch = false;
        let messageSearch = false;
        let interSearch = 0
        

        let low = 0;
        let high = this.source.length - 1;
        while (!resultSearch) {
            console.log(interSearch);
            if(low>high) {
            messageSearch="not found"
            resultSearch=true;
            }
            let mid =  low+((high-low)/(this.source[high]-this.source[low]))*(parseInt(saerchText)-this.source[low])
 
            interSearch++;
              let equal =  parseInt(saerchText) == (parseInt(this.source[mid]));
             
            if (equal) {
                resultSearch = true;
                messageSearch="found";
                break;
            }
            else if (parseInt(saerchText) > parseInt(this.source[mid])){
                low = mid + 1;
                

            }

            else if(parseInt(saerchText) < parseInt(this.source[mid])){
            high = mid - 1; 
            }

        }
        console.log({ count: interSearch, result: messageSearch });
         return { count: interSearch, result: messageSearch }
    }
}

export {
    Search
}