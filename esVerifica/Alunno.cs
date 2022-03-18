using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esVerifica
{
    class Alunno
    {
        
        //PROVA MODIFICA CS DA GITHUB
        private string _nome;
        private string _cognome;
        private int _eta;
        private string _citta;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public int Eta
        {
            get { return _eta; }
            set { _eta = value; }
        }

        public string Citta
        {
            get { return _citta; }
            set { _citta = value; }
        }

        public Alunno(string nome, string cognome, int eta, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            Citta = citta;
        }


        public void ModificaAluno(string nome, string cognome, int eta, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            Citta = citta;
        }

        public string CalcoloAnno()
        {
            string anno = " ";
            if(_eta < 16)
            {
                anno = "Biennio";
            }
            else if(_eta >= 16)
            {
                anno = "Triennio";
            }

            return anno;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome + " " + Eta + " " + Citta;
        }

    }
}
