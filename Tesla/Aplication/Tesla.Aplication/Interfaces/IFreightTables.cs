namespace Tesla.Aplication.Interfaces
{
    public interface IFreightTables
    {
        Domain.Domain.FreightTable GetFreight(string StartZipCode, string endZipCode);
    }
}
