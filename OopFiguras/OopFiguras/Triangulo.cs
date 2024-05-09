using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFiguras
{
    public class Triangulo
    {
        public int LadoX { get; set; }
        public int LadoY { get; set; }
        public int LadoZ { get; set; }

        public string Tipo { get; set; }

        public Triangulo(int ladoX, int ladoY, int ladoZ)
        {
            LadoX = ladoX;
            LadoY = ladoY;
            LadoZ = ladoZ;
        }

        public void TipoDeTriangulo()
        {
            if (LadoX == LadoY && LadoX == LadoZ)
            {
                Tipo = "Equilátero: Todos os lados iguais.";
            }else if (LadoX == LadoY || LadoX == LadoZ || LadoY == LadoZ)
            {
                Tipo = "Isósceles: Dois lados iguais.";
            }
            else
            {
                Tipo = "Escaleno: Todos os lados diferentes.";
            }
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
