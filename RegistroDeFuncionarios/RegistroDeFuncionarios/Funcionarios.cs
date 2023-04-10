using System.Globalization;

namespace empresa { 
class Funcionarios
{
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Sal { get; set; }

        public Funcionarios(int id, string nome, double sal)
        {
            Id = id;
            Nome = nome;
            Sal = sal;
        }
        public void Aumento(double per)
        {
            Sal += Sal * per / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ","
                + Nome
                + ","
                + Sal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
