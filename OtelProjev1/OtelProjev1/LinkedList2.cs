using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProjev1
{
    public class LinkedList2:LinkedListADT2
    {
        public override void InsertFirst(OtelYorumlari value)
        {
            Node2 tmpHead = new Node2
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }
        public LinkedList2 OteleGoreYorum (int OtelID)
        {
            Node2 tempNode = Head;
            LinkedList2 otelYorumlari = new LinkedList2();
       
            while (tempNode != null)
            {
                if ((tempNode.Data as OtelYorumlari).ID == OtelID)
                {
                    otelYorumlari.InsertFirst((tempNode.Data as OtelYorumlari));

                 
                }
                tempNode = tempNode.Next;
                
            }
            return otelYorumlari;
        }
        /*
       public override void InsertLast(int value)
       {
           //Eski sonuncu node, Head'den başlanarak set ediliyor
           Node oldLast = Head;

           if (Head == null)
               //Hiç kayıt eklenmediği için InsertFirst çağrılabilir
               InsertFirst(value);
           else
           {
               //Yeni sonuncu node yaratılıyor
               Node newLast = new Node
               {
                   Data = value
               };

               //Eski sonuncu node bulunuyor
               //Tail olsaydı sonuncuyu bulmaya gerek yoktu.
               while (oldLast.Next != null)
               {

                   oldLast = oldLast.Next;

               }

               //Eski sonuncu node referansı artık yeni sonuncu node'u gösteriyor
               oldLast.Next = newLast;

               //Bağlı listedeki eleman sayısı bir arttı
               Size++;
           }
       }

       public override void InsertPos(int position, int value)   //İstenen Pozisyona Ekleme
       {
           Node tempNode = Head;
           Node tempNextNode = null;

           Node newNode = new Node
           {
               Data = value
           };
           int count = 0;
           while (tempNode != null)
           {
               if (count == position)
               {
                   tempNextNode = tempNode.Next;
                   tempNode.Next = newNode;
                   newNode.Next = tempNextNode;
                   Size++;
               }
               tempNode = tempNode.Next;
               count++;
           }



       }

       public override void DeleteFirst()
       {
           if (Head != null)
           {
               //Head'in next'i HeadNext'e atanıyor
               Node tempHeadNext = this.Head.Next;
               //HeadNext null ise zaten tek kayıt olan Head silinir.
               if (tempHeadNext == null)
                   Head = null;
               else
                   //HeadNext null değilse yeni Head, HeadNext olur.
                   Head = tempHeadNext;
               //Listedeki eleman sayısı bir azaltılıyor
               Size--;
           }
       }

       public override void DeleteLast()
       {
           //Last node bulunup NULL yapılacak
           Node lastNode = Head;
           //Last node'dan bir önceki node'un Next'i null olacak
           Node lastPrevNode = null;

           while (lastNode.Next != null)
           {

               lastPrevNode = lastNode;
               lastNode = lastNode.Next;

           }
           //Listedeki eleman sayısı bir azaltılıyor
           Size--;
           //Last node null oldu
           lastNode = null;

           //Last node'dan önceki node varsa onun next'i null olacak yoksa zaten tek kayıt vardır, 
           //o da Head'dir, o da null olacak
           if (lastPrevNode != null)
               lastPrevNode.Next = null;
           else
               Head = null;
       }

       public override void DeletePos(int position)  //Belirli Pozisyondan silme işlemi
       {
           Node tempNode = Head;
           Node tempNextNode = null;
           Node prewNode = Head;
           int count = 0;

           while (tempNode != null)
           {
               if (count == position)
               {
                   tempNextNode = tempNode.Next;
                   prewNode.Next = tempNextNode;
                   tempNode = null;
                   Size--;
               }
               //Next node'a git
               prewNode = tempNode;
               tempNode = tempNode.Next;
               count++;
           }
       }

       public override Node GetElement(int position)
       {
           //Geri dönülecek eleman
           Node retNode = null;
           //Head'den başlanarak Next node'a gidilecek
           Node tempNode = Head;
           int count = 0;

           while (tempNode != null)
           {
               if (count == position)
               {
                   retNode = tempNode;
                   break;
               }
               //Next node'a git
               tempNode = tempNode.Next;
               count++;
           }
           return retNode;
       }
       
        public override string DisplayElements()
        {
            string temp = "";
            Node2 item = Head;
            while (item != null)
            {
                temp += item.Data.Ad;
                item = item.Next;
            }

            return temp;
        }
        public Node2 GetHead()
        {
            return Head;
        }
        */

    }
}
