namespace Tesla.Domain.Interfaces
{
    public interface IFreightTable
    {
        Domain.FreightTable GetFreight(string StartZipCode, string endZipCode);
    }
}
