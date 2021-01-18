using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class E5 {
        public E5 () {
            Serie[] arraySeries = {
                new Serie(),
                new Serie("Lost", "J. J. Abrams"),
                new Serie("The Mandalorian", 2, Serie.Generos.SCI_FI, "Disney"),
                new Serie("Alice in Wonderland", "Japones"),
                new Serie("The Simpsons", "Matt Groening")
            };

            Videojuego[] arrayVideojuegos = {
                new Videojuego(),
                new Videojuego("Cyberpunk 2077", "CD Project RED"),
                new Videojuego("The Witcher 3", 150, Videojuego.Generos.RPG, "CD Project RED"),
                new Videojuego("TESV: Skyrim", "Bethesda"),
                new Videojuego("Mario 64", "Nintendo Co."),
            };

            arraySeries[1].Entregar();
            arraySeries[1].Entregar();

            arrayVideojuegos[0].Entregar();
            arrayVideojuegos[3].Entregar();

            Serie maxSerie = arraySeries.Max();

            Videojuego maxVideojuego = arrayVideojuegos.Max();

            Console.WriteLine("El videojuego con mas horas es: ");
            Console.WriteLine(maxVideojuego.ToString());

            Console.WriteLine("La seriecon mas temporadas es: ");
            Console.WriteLine(maxSerie.ToString());
        }
    }
}
