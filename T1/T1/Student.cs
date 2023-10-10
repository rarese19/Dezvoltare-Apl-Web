using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Student
    {
        string nume;
        string prenume;
        int varsta;
        string identificator;
        public List<Materie> Materii;

        public Student()
        {
            nume = "anonim";
            prenume = "anonim";
            varsta = 1;
            identificator = "0A";
            Materii = new List<Materie>();
        }

        public void setNume(string nume) { this.nume = nume; }
        public void setPrenume(string prenume) { this.prenume = prenume; }
        public void setVarsta(int varsta) { this.varsta = varsta; }
        public void setID(string ID) { this.identificator  = ID; }  
        public void afisareMaterii() {
            Console.WriteLine("Materii: ");
            foreach (Materie mat in Materii){
                Console.WriteLine(mat.getTitlu() + "\n" + mat.getDurata());
            }
        }
        public void showInfo (){
            Console.WriteLine(nume + " " + prenume + "\n" + varsta + "\n" + identificator + "\n");
            afisareMaterii();
        }
        ~Student() { 
        }

    }
}
