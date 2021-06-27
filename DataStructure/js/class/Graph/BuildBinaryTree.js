class NodeTree {

    constructor(value, left = null, right = null) {
        this.value = value;
        this.left = left;
        this.right = right;
    }
}
class BinaryTree {
    constructor(root) {
        this.root = root;
     }

    addNode(newNode, root) {
        if (newNode.value > root.value) {
            if (root.right === null)
                root.right = newNode;
            else
                this.addNode(newNode, root.right);
        }
        if (newNode.value < root.value) {
            if (root.left === null)
                root.left = newNode;
            else
                this.addNode(newNode, root.left);
        }

 
    }

    search(value, parent) {
         if (parent != null)
        {
            if (value == parent.value) return parent;
            if (value < parent.value) 
                return this.search(value, parent.left);
              else
             return this.search(value, parent.right);
        }

        return null;
        
    }

    SearchDBF(text,node){
        if (node != null)
        {
            if(text==node.value){
                console.log("found");
            return node;
            }
            else{
            this.SearchDBF(text,node.left);
           this. SearchDBF(text,node.right);
            }
        }
        return null;

    }
    

    
 


}

export {
    BinaryTree,
    NodeTree
}