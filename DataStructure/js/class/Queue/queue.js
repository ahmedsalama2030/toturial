class Queue extends Array {
    constructor() {
        super();
        this.rear = -1;
        this.front = -1;
    }
    IsEmpty() {
        if (this.rear === -1 && this.front === -1)
            return true;
        else
            return false;


    }
    size(){
        return  this.length;
    }

    enQueue(value) {
        if (this.IsEmpty()) {
            this.front = this.rear = 0;
            super.push(value);
        }
        else {
            super.push(value);
            this.rear += 1;
        }
 
    }

    deQueue() {
        if (this.IsEmpty())
            return;
        if (this.front === this.rear) {
            this.front = this.rear = -1;
        }
        this.front += 1;
        return super.shift();

    }
    display(){
        super.forEach(element => {
            console.log(element);
        });
    }

}

export{
    Queue 
}