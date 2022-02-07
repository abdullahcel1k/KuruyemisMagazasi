using System;
using System.Collections.Generic;
using System.Text;

namespace KuruyemisMagazisiTwo
{
    class CaseTransaction : BaseProps, BaseMethods<CaseTransaction>
    {
        public static List<CaseTransaction> KasaHareketleri { get; set; }
        public TransactionTypeEnums TransactionType { get; set; }
        public double Amount { get; set; } // tutar

        public static void Add(CaseTransaction item)
        {
            KasaHareketleri.Add(item);
        }

        public  static void Delete(CaseTransaction item)
        {
            throw new NotImplementedException();
        }

        public static void List()
        {
            throw new NotImplementedException();
        }

        public static void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
