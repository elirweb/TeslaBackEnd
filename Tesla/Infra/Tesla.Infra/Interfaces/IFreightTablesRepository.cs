using Tesla.Domain.Domain;

namespace Tesla.Infra.Interfaces
{
    public interface IFreightTablesRepository: Common.IRepository
    {
        FreightTable GetFreight(string startZipCode, string endZipCode);
    }
}
