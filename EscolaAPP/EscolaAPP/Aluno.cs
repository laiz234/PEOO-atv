using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaAPP
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Matricula} - {Email}";
        }
    }
}
