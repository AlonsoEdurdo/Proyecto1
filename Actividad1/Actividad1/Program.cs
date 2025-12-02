using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de registro de Pokemon");
            Console.WriteLine("Registro del Pokemón: ");
            Console.WriteLine("Nombre del Pokemón: ");
            string n = Console.ReadLine();
            Console.WriteLine("Sexo del Pokemón: ");
            string s = Console.ReadLine();
            Console.WriteLine("Peso del Pokemón: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura del Pokemón: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Especie del Pokemón: ");
            string e = Console.ReadLine();
            Console.WriteLine("Nombre del poder básico: ");
            string pb = Console.ReadLine();
            Console.WriteLine("Daño del poder básico: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre del poder especial: ");
            string pe = Console.ReadLine();
            Console.WriteLine("Daño del poder especial: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("¿El pokemon es salvaje?: ");
            string z = Console.ReadLine();
            Console.WriteLine("Cuanto alimento le dara al Pokemón: ");
            int al = int.Parse(Console.ReadLine());
            double mot = 0.0;
            pokemon pk = new pokemon();
            pk.datos(n, s, e, p, a);
            pk.esSalvaje(z, 0);
            pk.pAlimenta(mot, al);
            pk.pReal(pb, pe, b, d, mot, 0);

        }
    }
    class pokemon
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
        }
        private string sexo;
        public string Sexo
        {
            get { return sexo; }
        }
        private double peso;
        public double Peso
        {
            get { return peso; }
        }
        private string especie;
        public string Especie
        {
            get { return especie; }
        }
        private double estatura;
        public double Estatura
        {
            get { return estatura; }
        }
        private string pbasico;
        public string Pbasico
        {
            get { return pbasico; }
        }
        private string pespecial;
        public string Pespecial
        {
            get { return pespecial; }
        }
        private int dbasico;
        public int Dbasico
        {
            get { return dbasico; }
        }
        private int despecial;
        public int Despecial
        {
            get { return despecial; }
        }
        private string salvaje;
        public string Salvaje
        {
            get { return salvaje; }
        }
        private double pexperiencia;
        public double Pexperiencia
        {
            get { return pexperiencia; }
        }
        private double motivacion;
        public double Motivacion
        {
            get { return motivacion; }
        }
        private double alimento;
        public double Alimento
        {
            get { return alimento; }
        }

        public void datos(string nombre, string sexo, string especie, double peso, double estatura)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.peso = peso;
            this.estatura = estatura;
            this.especie = especie;

            Console.WriteLine("Nombre pokemon: " + nombre);
            Console.WriteLine("Peso pokemon: " + peso);
            Console.WriteLine("Estatura del pokemon: "+estatura);
            Console.WriteLine("Especie del Pokemón: "+especie);

        }

        public void esSalvaje(string salvaje, double pexperiencia)
        {
            this.salvaje = salvaje;
            this.pexperiencia = pexperiencia = 0.0;
            if (salvaje.Equals("si"))
            {                
                Console.WriteLine("Puntos de experiencia del pokemon es igual a: "+pexperiencia);
            }
            else
            {
                double nexperiecia = pexperiencia+ 10;
                Console.WriteLine("Puntos de experiencia del pokemon es igual a: "+nexperiecia);
            }
        }
        public void pAlimenta(double motivacion, double alimento)
        {
            this.motivacion = motivacion;
            this.alimento = alimento;
            double m, p;
            if (alimento == 1)
            {
                m=motivacion + 0.1;
                p = alimento + 0.2;
                Console.WriteLine("Nivel de motivación: "+m);
                Console.WriteLine("Incremento de peso: " + p);
            }
            if (alimento == 2)
            {
                m = motivacion + 0.2;
                p = alimento + 0.4;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 3)
            {
                m = motivacion + 0.3;
                p = alimento + 0.6;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 4)
            {
                m = motivacion + 0.4;
                p = alimento + 0.8;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 5)
            {
                m = motivacion + 0.5;
                p = alimento + 1.0;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 6)
            {
                m = motivacion + 0.6;
                p = alimento + 1.2;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 7)
            {
                m = motivacion + 0.7;
                p = alimento + 1.4;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 8)
            {
                m = motivacion + 0.8;
                p = alimento + 1.6;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 9)
            {
                m = motivacion + 0.9;
                p = alimento + 1.8;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento == 10)
            {
                m = motivacion + 1.0;
                p = alimento + 2.0;
                Console.WriteLine("Nivel de motivación: " + m);
                Console.WriteLine("Peso actual: " + p);
            }
            if (alimento > 10)
            {
                Console.WriteLine("No se puede dar esa cantidad de alimento al Pokemón");
            }
        }
        public void pReal(string pbasico, string pespecial, int dbasico, int despecial, double motivacion, double pxperiencia)
        {
            this.pbasico = pbasico;
            this.pespecial = pespecial;
            this.dbasico = dbasico;
            this.despecial = despecial;
            int dataque = dbasico + despecial;
            double dreal = (dataque+(pexperiencia*0.50)+motivacion);
            Console.WriteLine("Poder basico: "+pbasico);
            Console.WriteLine("Daño poder básico: " + dbasico);
            Console.WriteLine("Poder especial: "+pespecial);
            Console.WriteLine("Daño poder especial: "+despecial);
            Console.WriteLine("Daño real: "+dreal);
            Console.WriteLine("Experiencia actualizada: ", pexperiencia+0.1);
        }
    }
}
