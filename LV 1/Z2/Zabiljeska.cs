using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    //2. Zadatak
    class Zabiljeska
    {
        private String tekst;
        private String autor;
        private int vaznost; // 1 - najvaznije, 5 - najmanje vazno

        public String getTekst()
        {
            Console.Write("Tekst: ");
            return this.tekst;
        }
        public String getAutor()
        {
            Console.Write("Autor: ");
            return this.autor;
        }
        public int getVaznost()
        {
            Console.Write("Vaznost: ");
            return this.vaznost;
        }

        public void setTekst(String tekst) { this.tekst = tekst; }
        public void setVaznost(int vaznost)
        {
            do
            {
                Console.Write("Neodgovarajuca vrjednost vaznosti!\nUnesite ponovo: ");
            } while (vaznost < 1 && vaznost > 5);
            this.vaznost = vaznost;
        }
    }
}

