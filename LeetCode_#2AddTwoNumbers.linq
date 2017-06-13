<Query Kind="Program" />

void Main()
{
	var result = AddTwoNumbers
	(
		new ListNode(5) { next = new ListNode(3) },
		new ListNode(4) { next = new ListNode(7)}
	);
	
	Console.Write(result);
}

public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{	
	var node1 = l1;
	var node2 = l2;
	
	var newListNode = new ListNode(-1);
	var nextNode = newListNode;// Reference Type
	var overFlowValue = 0;

	while (node1 != null && node2 != null)
	{		
		var node1Val = node1.val;
		var node2Val = node2.val;

		var sum = node1Val + node2Val + overFlowValue;
		overFlowValue = sum / 10;
		var remainderVal = sum % 10;

		nextNode.next = new ListNode(remainderVal);
		nextNode = nextNode.next;
		
		//// 把下一個 next 當成本次的 node 
		node1 = node1.next;
		node2 = node2.next;
	}

	if (overFlowValue > 0)
	{
		nextNode.next = new ListNode(overFlowValue);
	}
	
	return newListNode.next;
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}
