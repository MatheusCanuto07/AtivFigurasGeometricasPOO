using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivFigurasGeometricas.Models.FormaFiguras2D
{
    //Classe que não pode ser instaciada
    abstract class Forma
    {
        public Forma() {}

        protected double area;
        protected double perimetro;
        protected double quantLados;

        public abstract double calculaArea();
        public abstract double calculaPerimetro();

        public virtual void Mostrar()
        {
            Console.WriteLine(calculaArea().ToString()) ;
            Console.WriteLine(calculaPerimetro().ToString());
            Console.WriteLine("Imagem da figura");
        }
    }
}
