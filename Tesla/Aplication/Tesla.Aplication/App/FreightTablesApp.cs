using Tesla.Domain.Domain;

namespace Tesla.Aplication.App
{
    public class FreightTablesApp : Interfaces.IFreightTables
    {
        private readonly DomainService.Interfaces.IFreightTables freightTables;
        public FreightTablesApp(DomainService.Interfaces.IFreightTables freight)
        {
            this.freightTables = freight;
        }
        public FreightTable GetFreight(string startZipCode, string endZipCode)
        {
            return freightTables.GetFreight(startZipCode, endZipCode);
        }
    }
}
