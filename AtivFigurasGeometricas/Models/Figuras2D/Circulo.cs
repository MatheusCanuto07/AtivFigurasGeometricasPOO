using AtivFigurasGeometricas.Models.FormaFiguras2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace AtivFigurasGeometricas.Models.Figuras2D
{
    class Circulo : Forma
    {
        #region Contexto
        //Raio: Distância do centro do círculo até a borda.
        //Diâmetro: Distância entre dois pontos opostos na borda do círculo, passando pelo centro.
        //Área: Área total ocupada pelo círculo.
        //Circunferência/Perimetro : Comprimento da borda do círculo.
        //Área: π x Raio²
        //Perímetro: 2π x Raio
        //
        #endregion

        private double raio { get; set; }
        private double diametro { get; set; }

        public Circulo(double raio, double diametro)
        {
            this.raio = raio;
            this.diametro = diametro;
        }

        public override double calculaArea()
        {
            this.area = ConstantesMatematicas.Constante.Pi * (raio * raio);
            return this.area;
        }

        public override double calculaPerimetro()
        {
            this.perimetro = 2 * ConstantesMatematicas.Constante.Pi * raio;
            return this.perimetro;
        }
    }
}
