using System;
using System.Collections.Generic;
using System.Text;

namespace QuestaoD
{
    class Aluno
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public String Cidade { get; set; }

        public Boolean Status { get; set; }

        public Aluno ()
        {
            this.Status = true;
        }
    }
}
