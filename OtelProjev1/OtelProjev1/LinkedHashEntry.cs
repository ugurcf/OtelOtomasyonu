﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProjev1
{
    public class LinkedHashEntry
    {
        private int anahtar;

        private object deger;

        private LinkedHashEntry next;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }


        public LinkedHashEntry Next
        {
            get { return next; }
            set { next = value; }
        }


        public LinkedHashEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
            this.next = null;
        }

    }
}
