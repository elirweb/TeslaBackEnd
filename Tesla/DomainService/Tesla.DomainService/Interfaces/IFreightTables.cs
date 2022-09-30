using Tesla.Infra.Common;

namespace Tesla.DomainService.Interfaces
{
    public interface IFreightTables
    {
        Domain.Domain.FreightTable GetFreight(string StartZipCode, string endZipCode);
    }
}
