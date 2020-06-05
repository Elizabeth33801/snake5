using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Comida: Objeto
    {
        Graphics g;
        public Comida()
        {
            this.x = generar(79);
            this.y = generar(39);
        }
        public void dibujar(Graphics g)
        {
            // Genera colores aleatorios
            Random r = new Random();
            Color rColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            g.FillRectangle(new SolidBrush(rColor), this.x, this.y, this.ancho, this.ancho);
        }
        public void colocar()
        {
            this.x = generar(79);
            this.y = generar(39);
        }
             public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0,n)*10;
            return num;
        }
        public void CambiodeColor()
        {
            Random r = new Random();
            Color rColor= Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            g.FillRectangle(new SolidBrush(rColor), this.x, this.y, this.ancho, this.ancho);
        }
    }
   
}
