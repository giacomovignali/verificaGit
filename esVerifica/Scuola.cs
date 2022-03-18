using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//commento a caso
namespace esVerifica
{
    class Scuola
    {
        private string _nome;
        private string _indirizzo;
        private int _orarioApertura, _orarioChiusura;
        private List<Alunno> alunni;

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

       public void AggiungiAlunno()
       {
            alunni.Add(Alunno);
       }

        public int CalcolaAlunni()
        {
            int alunni = alunni.count();

            return alunni;
        }
        
        public void RicercaCognome()
        {

        }

        public void RicercaEta()
        {

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
