using System;
class BinaryTree
{
	public BinaryNode root;
	public BinaryTree(BinaryNode r)
	{
		this.root = r;
	}

	public BinaryNode ReturnRoot()
	{
		return root;
	}

	public void InsertIntoTree(int id)
	{
		//create a new node for the thee
		BinaryNode bn = new BinaryNode();

		//assign the id to the new node
		bn.item = id;

		//check if the root of the tree is null. If so, assign the new node
		if (root == null)
		{
			root = bn;
		}
		else   
		{
			//if root not null, assign that root as the current node
			BinaryNode currentNode = root;
			BinaryNode parentNode;//create a parent node
			while (true)
			{
				//assign the current node as the parent
				parentNode = currentNode;
				//if the passed id is less that the currentnode id, then assign the currentNode's left node as the current node.
				if (id < currentNode.item)
				{
					currentNode = currentNode.left;
					//if this node (currentNode) is null, then insert the new id to the tree (assign to the parentNode param left node because 
					//it is holding the original root node and id is less than the root(left))
					if (currentNode == null)
					{
						parentNode.left = bn;
					}
				}
				else
				{
					//do the above for the right side
					currentNode = currentNode.right;
					if (currentNode == null)
					{
						parentNode.right = bn;
					}

				}

			}
		}

	}
}