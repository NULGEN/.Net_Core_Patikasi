using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2__Console_ToDo_Uygulaması
{
    public class Board
    {
        public static List<Card> Line = new List<Card>();
        

        public Board()
        {
            Line.Add(new Card("Proje_1", "İçerik 1", 1, 2, "TODO"));
            Line.Add(new Card("Proje-2", "İçerik-2", 2, 3, "IN PROGRESS"));
            Line.Add(new Card("Proje-3", "İçerik-3", 3, 4, "DONE"));
            Line.Add(new Card("Proje-4", "İçerik-4.", 4, 4, "DONE"));
        }
        
    }
}
