using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProjev1
{
    public class Otel
    {
        public int OtelID { get; set; }
        public string Ad { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Yildiz { get; set; }
        public string OdaSayisi { get; set; }
        public string OdaTipi { get; set; }
        public string Puan { get; set; }
        public LinkedList OtelCalisani = new LinkedList();
        public LinkedList2 OtelYorumlari = new LinkedList2();

    }
}
