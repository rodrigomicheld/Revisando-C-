using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo212.Entities {
    abstract class Curso {
        public int Matricula { get; set; }
        public abstract override int GetHashCode();
        public override bool Equals(object obj) {
            if(!(obj is Curso)) {
                return false;
            }
            Curso other = obj as Curso;
            return Matricula.Equals(other.Matricula);
        }



    }
}
