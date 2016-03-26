using System;

namespace CollectionsCopyTo
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Trying to copy to buffer having size of 1 starting with index=1");
            TestCollections(false);
            
            Console.WriteLine("Trying to copy to buffer having size of 1 starting with index=2");
            TestCollections(true);
        }
        
        public static void TestCollections(bool useNextNonExistentIndex = false)
        {
            FormatExceptionDetails("Array", () => CopyToExample.ArrayCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("ArrayList", () => CopyToExample.ArrayListCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("BitArray", () =>CopyToExample.BitArrayCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("ConcurrentBag", () =>CopyToExample.ConcurrentBagCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("ConcurrentDictionary", () =>CopyToExample.ConcurrentDictionaryCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Dictionary", () =>CopyToExample.DictionaryCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("HashSet", () =>CopyToExample.HashSetCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Hashtable", () =>CopyToExample.HashtableCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("HybridDictionary", () =>CopyToExample.HybridDictionaryCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("List", () =>CopyToExample.ListCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("LinkedList", () =>CopyToExample.LinkedListCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("ListDictionary", () =>CopyToExample.ListDictionaryCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("NameValueCollection", () =>CopyToExample.NameValueCollectionCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Queue", () =>CopyToExample.QueueCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Queue (Generic)", () =>CopyToExample.QueueGenericCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Readonly collection", () =>CopyToExample.ReadOnlyCollectionCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("SortedDictionary", () => CopyToExample.SortedDictionaryCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("SortedList", () =>CopyToExample.SortedListCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("SortedList (Generic)", () => CopyToExample.SortedListGenericCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Sorted set", () => CopyToExample.SortedSetCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Stack", () => CopyToExample.StackCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("Stack (Generic)", () =>CopyToExample.StackGenericCopyTo(useNextNonExistentIndex));
            FormatExceptionDetails("StringDictionary", () => CopyToExample.StringDictionaryCopyTo(useNextNonExistentIndex));
        }
        
        public static void FormatExceptionDetails(string header, Action exampleAction)
        {
            Console.WriteLine(new String('-', 50));
            Console.WriteLine(header);
            try 
            {
                exampleAction();
                Console.WriteLine("No exceptions");
                Console.WriteLine();
            }
            catch(Exception exception)
            {

                Console.WriteLine(exception);
                Console.WriteLine();
            }
        }
    }
}
