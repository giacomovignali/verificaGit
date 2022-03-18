using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esVerifica
{
    class Scuola
    {
        private string _nome;
        private string _indirizzo;
        private int _orarioApertura, _orarioChiusura;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }
        public int OrarioApertura
        {
            get { return _orarioApertura; }
            set { _orarioApertura = value; }
        }

        public int OrarioChiusura
        {
            get { return _orarioChiusura; }
            set { _orarioChiusura = value; }
        }


        public Scuola(string nome, string indirizzo, int apertura, int chiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = apertura;
            OrarioChiusura = chiusura;
        }


    }
}
