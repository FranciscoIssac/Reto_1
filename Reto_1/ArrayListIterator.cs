using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_1
{
    class ArrayListIterator
    {
        private ArrayList arrayList;
        private int currentItem;

        public ArrayListIterator(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }

        public Boolean hasNext()
        {
            return currentItem < arrayList.getSize();
        }

        public String next()
        {
            String data = arrayList.getAt(currentItem);

            currentItem++;

            return data;
        }
    }
}
