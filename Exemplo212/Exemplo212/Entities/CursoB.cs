using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo212.Entities {
    class CursoB : Curso {
       
        public CursoB(int matricula) {
            Matricula = matricula;
        }
        // 
        public override int GetHashCode() {
            return Matricula.GetHashCode();
        }
        
        
    }
}
