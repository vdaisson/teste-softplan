namespace CalculaJuros.Domain.Service.Interfaces
{
    public interface ICalculaJurosService
    {
        decimal Calcula(double valorInicial, int meses);
    }
}
