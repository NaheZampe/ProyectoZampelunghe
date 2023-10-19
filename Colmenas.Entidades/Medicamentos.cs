namespace Colmenas.Entidades
{
    public class Medicamentos
    {
        public int IdMedicamento { get; set; }
        public string Medicamento { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
