using System;
using System.Collections.Generic;
using System.Text;

namespace Z5
{
    //5. Zadatak
    class Zabiljeska
    {
        private String tekst;
        private String autor;
        private int vaznost; // 1 - najvaznije, 5 - najmanje vazno


        //METODE
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
                vaznost = Convert.ToInt32(Console.ReadLine());
            } while (vaznost < 1 || vaznost > 5);
            Console.Write("Vaznost: ");
            this.vaznost = vaznost;
        }

        //KONSTRUKTORI
        public Zabiljeska()
        {
            this.tekst = string.Empty;
            this.autor = string.Empty;
            this.vaznost = 5;
        }
        public Zabiljeska(String tekst, String autor, int vaznost)
        {
            this.tekst = tekst;
            this.autor = autor;
            this.vaznost = vaznost;
        }
        public Zabiljeska(String tekst, String autor)
        {
            this.tekst = tekst;
            this.autor = autor;
            this.vaznost = 5;
        }


        //SVOJSTVA
        public string Tekst
        {
            get { return this.tekst; }
            set
            {
                this.tekst = value; 
            }
        }
        private string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public int Vaznost
        {
            get { return this.vaznost; }
            set
            {
                do
                {
                    Console.Write("Neodgovarajuca vrjednost vaznosti!\nUnesite ponovo: ");
                    vaznost = Convert.ToInt32(Console.ReadLine());
                } while (vaznost < 1 || vaznost > 5);
                Console.Write("Vaznost: ");
                this.vaznost = value;
            }
        }

        //ToString
        public override string ToString()
        {
            return "Tekst: " + this.tekst + "\nAutor: " + this.autor + "\nVaznost: " + this.vaznost;
        }

    }
}

