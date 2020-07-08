using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_de_notas_da_escola
{
    class Aluno
    {
        public string Nome;
        public int Nota1, Nota2, Nota3;
      

        public int Media()
        { 
                 return Nota1 + Nota2 + Nota3;
        }

        public int Rest()
        {
            return Media() - 60;
        }
    }
}

