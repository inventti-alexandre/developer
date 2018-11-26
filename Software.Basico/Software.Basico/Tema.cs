using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico
{
    class Tema
    {
        public static Color Principal { get; set; }
        public static Color Primaria { get; set; }
        public static Color Segundaria { get; set; }
        public static Color Terciaria { get; set; }
        public static Color Texto { get; set; }

        public void CarregarTema1()
        {
            Principal = Color.FromArgb(163, 163, 163);
            Primaria = Color.FromArgb(13, 19, 23);
            Segundaria = Color.FromArgb(16, 29, 66);
            Terciaria = Color.FromArgb(101, 100, 219);
            Texto = Color.FromArgb(163, 163, 163);
        }

        public void CarregarTema2()
        {
            Principal = Color.FromArgb(88, 164, 176);
            Primaria = Color.FromArgb(43, 48, 58);
            Segundaria = Color.FromArgb(12, 124, 89);
            Terciaria = Color.FromArgb(214, 73, 51);
            Texto = Color.FromArgb(88, 164, 176);
        }
    }
}
