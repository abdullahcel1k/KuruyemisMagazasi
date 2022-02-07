using System;
using System.Collections.Generic;
using System.Text;

namespace KuruyemisMagazisiTwo
{
    interface BaseMethods<T>
    {
        public static void Add(T item) { }
        public static void Delete(T item) { }
        public static void Update(int id) { }
        public static void List() { }
    }
}
