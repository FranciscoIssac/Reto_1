using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_1
{
    class ArrayList
    {
        private const int DEFAULT_SIZE = 50;
        private String[] array;
        private int size;

        public ArrayList()
        {
            array = new String[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new String[size];
        }

        public void addAtTail(String data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            this.array[size] = data;
            size++;
        }

        public void addAtFront(String data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            if (size >= 0)
                for(int i = size ; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0)
            {
                for(int i = index; i < size; i++)
                {
                    array[i] = array[i + 1];
                }
            }

            array[size - 1] = null;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        public void setAt(int index, String data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        /**
         *
         * @param index =-index
         * @return element at position index
         */

        public String getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : null;
        }

        public ArrayListIterator getIterator()
        {
            return new ArrayListIterator(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            String[] newArray = new String[array.Length * 2];

            if (size >= 0)
                for (int i = 1; i < size; i--)
                {
                    newArray[i] = array[i];
                }

            array = newArray;
        }
    }
}
