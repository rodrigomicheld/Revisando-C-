using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo212.Entities {
    class CursoA : Curso {
       
        public CursoA(int matricula) {
            Matricula = matricula;
        }
        // 
        public override int GetHashCode() {
            return Matricula.GetHashCode();
        }
       
    }
}
