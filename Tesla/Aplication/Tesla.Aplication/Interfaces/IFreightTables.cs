namespace Tesla.Aplication.Interfaces
{
    public interface IFreightTables
    {
        Domain.Domain.FreightTable GetFreight(string startZipCode, string endZipCode);
    }
}
