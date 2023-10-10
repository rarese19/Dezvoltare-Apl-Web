using System.Collections.Specialized;
using T1;

List<Student> students = new List<Student>();

Console.WriteLine("Numarul de studenti: ");
int nrStudenti = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=nrStudenti; i++){
    Console.WriteLine("STUDENT " +  i);

    Student student = new Student();

    Console.WriteLine("Nume: ");
    student.setNume(Console.ReadLine());

    Console.WriteLine("Prenume: ");
    student.setPrenume(Console.ReadLine());

    Console.WriteLine("Varsta: ");
    student.setVarsta(Convert.ToInt32(Console.ReadLine()));

    Console.WriteLine("Identificator: ");
    student.setID(Console.ReadLine());

    Console.WriteLine("Nr materii: ");
    int nr = Convert.ToInt32(Console.ReadLine());


    for (int j=1; j<=nr; j++){
        Console.WriteLine("Materia " + j);
        Materie materie = new Materie();

        Console.WriteLine("Nume materie: ");
        materie.setTitlu(Console.ReadLine());

        Console.WriteLine("Durata: ");
        materie.setDurata(Console.ReadLine());
        Console.WriteLine("\n");

        student.Materii.Add(materie);
    }
    students.Add(student);
}

foreach (Student s in students){
    s.showInfo();
}