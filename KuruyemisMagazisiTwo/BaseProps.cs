using System;
using System.Collections.Generic;
using System.Text;

namespace KuruyemisMagazisiTwo
{
    abstract class BaseProps
    {
        const int MIN_IDS = 10000;
        const int MAX_IDS = 100000;
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public BaseProps()
        {
            Random rastgele = new Random();
            Id = rastgele.Next(MIN_IDS, MAX_IDS);
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
        }
    }
}
