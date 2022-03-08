using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class MyMapNode<K, V>
    {
        //Fields.
        public LinkedList<KeyValuePair<K, V>>[] items;
        public int size;

        //Constructor for initializing the array size.
        public MyMapNode(int size)
        {
            items = new LinkedList<KeyValuePair<K, V>>[size];
            this.size = size;
        }
        //Checking the Key, exists or not !
        public int CheckWord(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> list = items[position];
            int count = 1;
            bool keyFound = false;
            KeyValuePair<K, V> removingKvPairs = null;
            if (list != null)
            {
                foreach (KeyValuePair<K, V> pair in list)
                {
                    if (pair.key.Equals(key))
                    {
                        keyFound = true;
                        removingKvPairs = pair;
                        count = Convert.ToInt32(pair.value) + 1;
                    }
                    else
                    {
                        count = count;
                    }
                }
                if (keyFound == true)
                {
                    list.Remove(removingKvPairs);
                }
            }
            else
            {
                count = 1;
            }
            return count;
        }

        //Getting the position of Array as being fetched with the help of key.
        public int GetArrayPosition(K Key)
        {
            int hashCode = Key.GetHashCode();
            var result = hashCode % size;
            return Math.Abs(result);
        }
        //For grtting a Value as being requested with the reference of key.
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> list = items[position];
            if (list != null)
            {

                foreach (var kv in list)
                {
                    if (kv.key.Equals(key))
                    {
                        return kv.value;
                    }
                }
            }
            return default(V);
        }
        //For removing Key Value pairs by inputing the key.
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            KeyValuePair<K, V> removingKvPairs = null;
            foreach (KeyValuePair<K, V> kv in linkedList)
            {
                if (kv.key.Equals(key))
                {
                    removingKvPairs = kv;
                }
            }
            linkedList.Remove(removingKvPairs);
        }
        //For displaying key & its value simultaneously on Console.
        public void Display(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> LinkedListofPosition = GetLinkedList(position);
            foreach (KeyValuePair<K, V> keyValue in LinkedListofPosition)
            {
                if (keyValue.key.Equals(key))
                {
                    Console.WriteLine("Key: " + keyValue.key + "\t Value: " + keyValue.value);
                }
            }
        }
        //For Adding Key-Value pairs in the list as per the position fetched by key value.
        public void Add(K Key, V Value)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            KeyValuePair<K, V> keyValue = new KeyValuePair<K, V>() { key = Key, value = Value };
            linkedList.AddLast(keyValue);
        }
        //To fetch the linked list at a certain position as being formulated with  key value.
        public LinkedList<KeyValuePair<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

    }
    //Defining the KeyValuePair generic class.
    public class KeyValuePair<K, V>
    {
        public K key;
        public V value;
    }
}