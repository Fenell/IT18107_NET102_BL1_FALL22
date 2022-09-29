using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_GENERIC_CLASS
{
    internal class ClassGeneric<T>
    {
        //Thêm thuộc tính cho class
        private T[] items;
        //Constructor
        public ClassGeneric(int size)
        {
            //Khởi tạo mảng Item T
            Items = new T[size];
        }
        //property
        public T[] Items { get => items; set => items = value; }

        //add thêm phần tử cho items
        public void addItemElement (int index, T element)
        {
            if (index < 0 && index > items.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            items[index] = element;
        }

        //Phương thức lấy giá trị phần tử của item
        public T getItemElement(int index)
        {
            if (index < 0 && index > items.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            return items[index];
        }
    }
}
