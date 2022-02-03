using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesProgram
{
    //Creating The MapNode(UC1)
    public class MyMapNode<K, V>
    {
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }

        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        //Method to get the index number
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        //Method to get the array position i.e 0,1 etc and linkedlist 
        public LinkedList<KeyValue<K, V>> GetArrayPositionAndLinkedList(K Key)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            return linkedList;
        }

        //Method to return the value at given key
        public V Get(K key)
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }
            return default;
        }

        //Method for adding the key and value in the linkedlist
        public void Add(K key, V value)
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            if(linkedList.Count != 0)
            {
                foreach(KeyValue<K, V> newItem in linkedList)
                {
                    if (newItem.Key.Equals(key))
                    {
                        //Method to remove existing unique key to add new key with new value count in add method
                        Remove(key);
                        break;
                    }
                }
            }
            linkedList.AddLast(item);
        }

        //Method to check the given key exists or not
        public bool Exists(K key)
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        //Method to remove existing unique key 
        public void Remove(K key)
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        //Method to add the linklist to given position
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        //Method to display the result
        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (var element in linkedList)
                    {
                        string resStr = element.ToString();
                        if (!string.IsNullOrEmpty(resStr))
                            Console.WriteLine("Key : {0} || Value : {1}",element.Key, element.Value);
                    }
                }
            }
        }
    }
}
