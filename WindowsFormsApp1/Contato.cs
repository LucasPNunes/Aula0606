using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Contato
    {
        public int id;
        public string nome;
        public string telefone;

        public Contato(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
