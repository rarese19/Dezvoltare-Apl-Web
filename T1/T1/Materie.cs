using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Materie
    {
        string titlu;
        string durata;
        public Materie() {
            titlu = "Anonim";
            durata = "0 Ore";
        }

        public void setTitlu(string titlu) { this.titlu = titlu; }
        public string getTitlu() {  return this.titlu; }
        public void setDurata(string durata) {  this.durata = durata; }
        public string getDurata() {  return this.durata; }
    }
}
