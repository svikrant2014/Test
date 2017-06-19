        // reverse a LinkedList
        public void printInReverse()
        {
            MyNode current = head;

            MyNode next, prev = null;

            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            head = prev; 

            printallnodes();
        }
        
        // reverse a LinkedList using recursion
        public void reverseusingrecrsion(MyNode head1)
        {
            if (head1.next == null)
            {
                head = head1;
                return;
            }
            reverseusingrecrsion(head1.next);

            MyNode temp = head1.next;
            temp.next = head1;
            head1.next = null;
            Console.WriteLine(temp.data);
        }        
        
        
        /// <summary>
        /// In place merge algo considering first array A has sufficient space to hold all the elements from both arrays
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="m">current number of elements in A</param>
        public static void mergetwosortedarray(int[] A,int m, int[] B)
        {
            int i = m-1;
            int j = B.Length-1;

            int k = A.Length-1;

            while (i >= 0 && j >= 0)
            {
                if (A[i] > B[j])
                {
                    A[k] = A[i];
                    i--;
                }
                else
                {
                    A[k] = B[j];
                    j--;
                }

                k--;
            }

            while(i>=0)
            {
                A[k] = A[i];
                k--; i--;
            }
        }
