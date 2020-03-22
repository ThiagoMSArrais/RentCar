namespace TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces
{
    public interface IClienteRepository
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
    }
}
