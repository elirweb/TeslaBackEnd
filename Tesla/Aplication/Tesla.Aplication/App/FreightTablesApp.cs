using Tesla.Domain.Domain;

namespace Tesla.Aplication.App
{
    public class FreightTablesApp : Interfaces.IFreightTables
    {
        private readonly DomainService.Interfaces.IFreightTables freightTablesService;
        public FreightTablesApp(DomainService.Interfaces.IFreightTables freight)
        {
            this.freightTablesService = freight;
        }
        public FreightTable GetFreight(string startZipCode, string endZipCode)
        {
            return freightTablesService.GetFreight(startZipCode, endZipCode);
        }
    }
}
