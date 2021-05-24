using System.Collections.Generic;

namespace ToolLibrary
{
	public class BTreeNode
	{
		private Member member;
		private BTreeNode leftChild;
		private BTreeNode rightChild;

		public BTreeNode(Member item)
		{
			member = item;
			leftChild = null;
			rightChild = null;
		}

		public Member Member
		{
			get { return member; }
			set { member = value; }
		}

		public BTreeNode LeftChild
		{
			get { return leftChild; }
			set { leftChild = value; }
		}

		public BTreeNode RightChild
		{
			get { return rightChild; }
			set { rightChild = value; }
		}
	}


	public class BSTree
	{
		private BTreeNode root;

		public BSTree()
		{
			root = null;
		}

		public bool IsEmpty()
		{
			return root == null;
		}

		public bool Search(Member member)
		{
			return Search(member, root);
		}

		private bool Search(Member member, BTreeNode r)
		{
			if (r != null)
			{
				if (member.LastName.CompareTo(r.Member.LastName) == 0)
                {
					if (member.FirstName.CompareTo(r.Member.FirstName) == 0)
						return true;
					else
						if (member.FirstName.CompareTo(r.Member.FirstName) < 0)
							return Search(member, r.LeftChild);
						else
							return Search(member, r.RightChild);
				}
				else
					if (member.LastName.CompareTo(r.Member.LastName) < 0)
					return Search(member, r.LeftChild);
				else
					return Search(member, r.RightChild);
			}
			else
				return false;
		}

		public void Insert(Member member)
		{
			if(root == null)
				root = new BTreeNode(member);
			else
				Insert(member, root);	
		}

		// pre: ptr != null
		// post: item is inserted to the binary search tree rooted at ptr
		private void Insert (Member member, BTreeNode ptr)
		{
			if (member.LastName.CompareTo(ptr.Member.LastName) == 0)
            {
				if (member.FirstName.CompareTo(ptr.Member.FirstName) < 0)
				{
					if (ptr.LeftChild == null)
						ptr.LeftChild = new BTreeNode(member);
					else
						Insert(member, ptr.LeftChild);
				}
				else
				{
					if (ptr.RightChild == null)
						ptr.RightChild = new BTreeNode(member);
					else
						Insert(member, ptr.RightChild);
				}
			}
			else
            {
				if (member.LastName.CompareTo(ptr.Member.LastName) < 0)
				{
					if (ptr.LeftChild == null)
						ptr.LeftChild = new BTreeNode(member);
					else
						Insert(member, ptr.LeftChild);
				}
				else
				{
					if (ptr.RightChild == null)
						ptr.RightChild = new BTreeNode(member);
					else
						Insert(member, ptr.RightChild);
				}
			}
		} 
	
		// there are three cases to consider:
		// 1. the node to be deleted is a leaf
		// 2. the node to be deleted has only one child 
		// 3. the node to be deleted has both left and right children
		public void Delete(Member member)
		{
			// search for item and its parent
			BTreeNode ptr = root; // search reference
			BTreeNode parent = null; // parent of ptr
			while((ptr!=null)&&(member.LastName.CompareTo(ptr.Member.LastName)!=0)
				&&(member.LastName.CompareTo(ptr.Member.LastName)!=0))
			{
				parent = ptr;
				if (member.LastName.CompareTo(ptr.Member.LastName) == 0)
                {
					if (member.FirstName.CompareTo(ptr.Member.FirstName) < 0) // move to the left child of ptr
						ptr = ptr.LeftChild;
					else
						ptr = ptr.RightChild;
				}
				else
                {
					if (member.LastName.CompareTo(ptr.Member.LastName) < 0) // move to the left child of ptr
						ptr = ptr.LeftChild;
					else
						ptr = ptr.RightChild;
				}
			}

			if(ptr != null) // if the search was successful
			{
				// case 3: item has two children
				if((ptr.LeftChild != null)&&(ptr.RightChild != null))
				{
					// find the right-most node in left subtree of ptr
					if(ptr.LeftChild.RightChild == null) // a special case: the right subtree of ptr.LChild is empty
					{
						ptr.Member.LastName = ptr.LeftChild.Member.LastName;
						ptr.Member.FirstName = ptr.LeftChild.Member.FirstName;
						ptr.LeftChild = ptr.LeftChild;
					}
					else 
					{
						BTreeNode p = ptr.LeftChild;
						BTreeNode pp = ptr; // parent of p
						while(p.RightChild != null)
						{
							pp = p;
							p = p.RightChild;
						}
						// copy the item at p to ptr
						ptr.Member.LastName = p.Member.LastName;
						pp.RightChild = p.LeftChild;
					}
				}
				else // cases 1 & 2: item has no or only one child
				{
					BTreeNode c;
					if(ptr.LeftChild != null)
						c = ptr.LeftChild;
					else
						c = ptr.RightChild;

					// remove node ptr
					if(ptr == root) //need to change root
						root = c;
					else
					{
						if(ptr == parent.LeftChild)
							parent.LeftChild = c;
						else
							parent.RightChild = c;
					}
				}

			}
		}

		public void Clear()
		{
			root = null;
		}

		public Member[] ToArray()
		{
			List<Member> memberList = new();

			void PreOrderTraverse(BTreeNode root)
			{
				if (root != null)
				{
					memberList.Add(root.Member);
					PreOrderTraverse(root.LeftChild);
					PreOrderTraverse(root.RightChild);
				}
			}

			PreOrderTraverse(root);

			return memberList.ToArray();
		}
	}
}