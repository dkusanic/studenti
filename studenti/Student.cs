using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenti
{
    class Student
    {
        public string KorisnickaOznaka { get; set; }
        public string Mentor { get; set; }
        public int PolozeneVjezbe { get; set; }
       

        public static List<Student> dohvatiStudente()
        {
            Student st = null;
            List<Student> lista = new List<Student>();
            string[] csv = File.ReadAllLines(@"C:\Users\Domagoj\Documents\vjezba studenti\studenti\studenti.csv");
            foreach (string s in csv)
            {
                st = new Student();
                string[] razdvojeno = s.Split(';');
                st.KorisnickaOznaka = razdvojeno[0];
                st.Mentor = razdvojeno[1];
                st.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                lista.Add(st);
            }
            return lista;
        }

        public static List<Student> VjezbeDa()
        {
            Student st = null;
            List<Student> lista = new List<Student>();
            string[] csv = File.ReadAllLines(@"C:\Users\Domagoj\Documents\vjezba studenti\studenti\studenti.csv");
            foreach (string s in csv)
            {
                st = new Student();
                string[] razdvojeno = s.Split(';');
                st.KorisnickaOznaka = razdvojeno[0];
                st.Mentor = razdvojeno[1];
                st.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                if (st.PolozeneVjezbe == 1)
                    lista.Add(st);
            }
            return lista;
        }

        public static List<Student> VjezbeNe()
        {
            Student st = null;
            List<Student> lista = new List<Student>();
            string[] csv = File.ReadAllLines(@"C:\Users\Domagoj\Documents\vjezba studenti\studenti\studenti.csv");
            foreach (string s in csv)
            {
                st = new Student();
                string[] razdvojeno = s.Split(';');
                st.KorisnickaOznaka = razdvojeno[0];
                st.Mentor = razdvojeno[1];
                st.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                if (st.PolozeneVjezbe == 0)
                    lista.Add(st);
            }
            return lista;
        }

        public static List<Student> mentorFilter(string txtbox)
        {
            Student st = null;
            List<Student> lista = new List<Student>();
            string[] csv = File.ReadAllLines(@"C:\Users\Domagoj\Documents\vjezba studenti\studenti\studenti.csv");
            foreach (string s in csv)
            {
                st = new Student();
                string[] razdvojeno = s.Split(';');
                st.KorisnickaOznaka = razdvojeno[0];
                st.Mentor = razdvojeno[1];
                st.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                if (st.Mentor.Contains(txtbox))
                    lista.Add(st);
            }
            return lista;
        }
    }
}
