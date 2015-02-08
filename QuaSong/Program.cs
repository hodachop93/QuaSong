using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaSong
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // 0: bap cai, 1: cuu, 2: soi
            List<int> Open = new List<int>(){0,1,2};
            List<int> Close = new List<int>();
            while (Open.Count != 0)
            {
                // Qua trinh sang song
                for (int i=0;i<Open.Count;i++)
                {
                    if (sangSong(Open, i))
                    {
                        switch (Open[i])
                        {
                            case 0:
                                Console.WriteLine("Dua bap cai tu bo 1 sang bo 2");
                                break;
                            case 1:
                                Console.WriteLine("Dua cuu tu bo 1 sang bo 2");
                                break;
                            case 2:
                                Console.WriteLine("Dua soi tu bo 1 sang bo 2");
                                break;
                        }
                        Close.Add(Open[i]);
                        Open.RemoveAt(i);
                        break;
                    }
                }
                //Qua trinh tro ve
                for (int i = 0; i < Close.Count-1; i++)
                {
                    if (troVe(Close, i))
                    {
                        switch (Close[i])
                        {
                            case 0:
                                Console.WriteLine("Dua bap cai tu bo 2 sang bo 1");
                                break;
                            case 1:
                                Console.WriteLine("Dua cuu tu bo 2 sang bo 1");
                                break;
                            case 2:
                                Console.WriteLine("Dua soi tu bo 2 sang bo 1");
                                break;
                        }
                        Open.Add(Close[i]);
                        Close.RemoveAt(i);
                        break;
                    }
                }
            }
            Console.Read();
            
        }
        public static bool sangSong(List<int> open, int index)
        {
            if (open.Count <= 2)
                return true;
            List<int> temp = new List<int>();
            //Sao chep mang open vao mang tam temp
            foreach (int i in open)
            {
                temp.Add(i);
            }
            //Loai bo phan tu da qua song
            temp.RemoveAt(index);
            //Kiem tra phan tu o lai xem co hop he hay ko
            if (Math.Abs(temp[0]-temp[1])==1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool troVe(List<int> close, int index)
        {
            if (close.Count < 2)
                return false;
            if (Math.Abs(close[0] - close[1]) == 1)
                return true;
            else
                return false;
        }
        
    }

    
    
}
