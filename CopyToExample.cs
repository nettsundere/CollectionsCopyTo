using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Specialized;

namespace CollectionsCopyTo
{
    public static class CopyToExample
    {
        public static void ArrayCopyTo(bool greaterIndex = false)
        {
            var array = new string[0];
            var buffer = new string[1];
            if(greaterIndex)
            {
                array.CopyTo(buffer, 2);
            }
            else
            {
                array.CopyTo(buffer, 1);
            }
        }
        public static void ArrayListCopyTo(bool greaterIndex = false) {
            var arrayList = new ArrayList();
            var buffer = new object[1];
            if(greaterIndex)
            {
                arrayList.CopyTo(buffer, 2);
            }
            else
            {
                arrayList.CopyTo(buffer, 1);
            }
        }
        
        public static void BitArrayCopyTo(bool greaterIndex = false) {
            var bitArray = new BitArray(20, false);
            var bitArrayAsCollection = bitArray as ICollection;
            var buffer = new bool[1];
            if(greaterIndex)
            {
                bitArrayAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                bitArrayAsCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void ConcurrentBagCopyTo(bool greaterIndex = false)
        {
            var concurrentBag = new ConcurrentBag<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                concurrentBag.CopyTo(buffer, 2);
            }
            else
            {
                concurrentBag.CopyTo(buffer, 1);
            }
        }
        
        public static void ConcurrentDictionaryCopyTo(bool greaterIndex = false)
        {
            var dictionary = new ConcurrentDictionary<string, string>();
            var buffer = new KeyValuePair<string, string>[1];
            var dictionaryAsCollection = dictionary as ICollection;
            if(greaterIndex)
            {
                dictionaryAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                dictionaryAsCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void DictionaryCopyTo(bool greaterIndex = false)
        {
            var dictionary = new Dictionary<string, string>();
            var buffer = new KeyValuePair<string, string>[1];
            var dictionaryAsCollection = dictionary as ICollection;
            if(greaterIndex)
            {
                dictionaryAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                dictionaryAsCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void HashSetCopyTo(bool greaterIndex = false)
        {
            var hashSet = new HashSet<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                hashSet.CopyTo(buffer, 2);
            }
            else
            {
                hashSet.CopyTo(buffer, 1);
            }
        }
        
        public static void HashtableCopyTo(bool greaterIndex = false)
        {
            var hashTable = new Hashtable();
            var buffer = new KeyValuePair<string, string>[1];
            var hashtableAsCollection = hashTable as ICollection;
            if(greaterIndex)
            {
                hashtableAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                hashtableAsCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void HybridDictionaryCopyTo(bool greaterIndex = false)
        {
            var hybridDictionary = new HybridDictionary();
            var buffer = new KeyValuePair<string, string>[1];
            var hybridDictionaryAsCollection = hybridDictionary as ICollection;
            if(greaterIndex)
            {
                hybridDictionaryAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                hybridDictionaryAsCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void ListCopyTo(bool greaterIndex = false)
        {
            var list = new List<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                list.CopyTo(buffer, 2);
            }
            else
            {
                list.CopyTo(buffer, 1);
            }
        }
        
        public static void LinkedListCopyTo(bool greaterIndex = false)
        {
            var linkedList = new LinkedList<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                linkedList.CopyTo(buffer, 2);
            }
            else
            {
                linkedList.CopyTo(buffer, 1);
            }
        }
        
        public static void ListDictionaryCopyTo(bool greaterIndex = false)
        {
            var listDictionary = new ListDictionary();
            var buffer = new object[1];
            if(greaterIndex)
            {
                listDictionary.CopyTo(buffer, 2);
            }
            else
            {
                listDictionary.CopyTo(buffer, 1);
            }
        }
        
        public static void NameValueCollectionCopyTo(bool greaterIndex = false)
        {
            var nameValueCollection = new NameValueCollection();
            var buffer = new string[1];
            if(greaterIndex)
            {
                nameValueCollection.CopyTo(buffer, 2);
            }
            else
            {
                nameValueCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void QueueGenericCopyTo(bool greaterIndex = false)
        {
            var queue = new Queue<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                queue.CopyTo(buffer, 2);
            }
            else
            {
                queue.CopyTo(buffer, 1);
            }
        }

        public static void QueueCopyTo(bool greaterIndex = false)
        {
            var queue = new Queue();
            var buffer = new object[1];
            if(greaterIndex)
            {
                queue.CopyTo(buffer, 2);
            }
            else
            {
                queue.CopyTo(buffer, 1);
            }
        }

        public static void ReadOnlyCollectionCopyTo(bool greaterIndex = false)
        {
            var readonlyCollection = new List<string>().AsReadOnly();
            var buffer = new string[1];
            if(greaterIndex)
            {
                readonlyCollection.CopyTo(buffer, 2);
            }
            else
            {
                readonlyCollection.CopyTo(buffer, 1);
            }
        }

        public static void SortedDictionaryCopyTo(bool greaterIndex = false)
        {
            var sortedDictioanary = new SortedDictionary<string, string>();
            var buffer = new KeyValuePair<string, string>[1];
            var sortedDictionaryAsCollection = sortedDictioanary as ICollection;
            if(greaterIndex)
            {
                sortedDictionaryAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                sortedDictionaryAsCollection.CopyTo(buffer, 1);
            }
        }
        
        public static void SortedListGenericCopyTo(bool greaterIndex = false)
        {
            var sortedList = new SortedList<string, string>();
            var buffer = new KeyValuePair<string, string>[1];
            var sortedListAsCollection = sortedList as ICollection;
            if(greaterIndex)
            {
                sortedListAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                sortedListAsCollection.CopyTo(buffer, 1);
            }
        }

        public static void SortedListCopyTo(bool greaterIndex = false)
        {
            var sortedList = new SortedList();
            var buffer = new KeyValuePair<object, object>[1];
            var sortedListAsCollection = sortedList as ICollection;
            if(greaterIndex)
            {
                sortedListAsCollection.CopyTo(buffer, 2);
            }
            else
            {
                sortedListAsCollection.CopyTo(buffer, 1);
            }
        }

        public static void SortedSetCopyTo(bool greaterIndex = false)
        {
            var sortedSet = new SortedSet<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                sortedSet.CopyTo(buffer, 2);
            }
            else
            {
                sortedSet.CopyTo(buffer, 1);
            }
        }
        
        public static void StackGenericCopyTo(bool greaterIndex = false)
        {
            var stack = new Stack<string>();
            var buffer = new string[1];
            if(greaterIndex)
            {
                stack.CopyTo(buffer, 2);
            }
            else
            {
                stack.CopyTo(buffer, 1);
            }
        }

        public static void StackCopyTo(bool greaterIndex = false)
        {
            var stack = new Stack();
            var buffer = new object[1];
            if(greaterIndex)
            {
                stack.CopyTo(buffer, 2);
            }
            else
            {
                stack.CopyTo(buffer, 1);
            }
        }

        public static void StringDictionaryCopyTo(bool greaterIndex = false)
        {
            var stringDictionary = new StringDictionary();
            var buffer = new string[1];
            if(greaterIndex)
            {
                stringDictionary.CopyTo(buffer, 2);
            }
            else
            {
                stringDictionary.CopyTo(buffer, 1);
            }
        }
    }
    
}
