public class AddTwoNumbersresult
{
    public void AddTwoNumberResult()
    {
        Solution objAddTwoNumbers = new Solution();
        ListNode l1 = null;
        /*l1 = objAddTwoNumbers.AddFirst(9);
        l1 = objAddTwoNumbers.AddFirst(9);
        l1 = objAddTwoNumbers.AddFirst(9);
        l1 = objAddTwoNumbers.AddFirst(9);
        l1 = objAddTwoNumbers.AddFirst(9);
        l1 = objAddTwoNumbers.AddFirst(9);
        l1 = objAddTwoNumbers.AddFirst(9);*/
        l1 = objAddTwoNumbers.AddFirst(9);

        objAddTwoNumbers.head = null;

        ListNode l2 = null;
       /* l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);*/
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(9);
        l2 = objAddTwoNumbers.AddFirst(1);

        Console.WriteLine("l1:");
        objAddTwoNumbers.PrintList(l1);
        Console.WriteLine();
        Console.WriteLine("l2:");
        objAddTwoNumbers.PrintList(l2);
        Console.WriteLine();
        Console.WriteLine("output:");
        objAddTwoNumbers.AddTwoNumbers(l1, l2);
        Console.ReadLine();
    }
}