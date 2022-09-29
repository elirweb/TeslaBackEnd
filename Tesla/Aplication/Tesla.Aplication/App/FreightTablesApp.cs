using System;
using System.Collections.Generic;
using System.Text;
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
        public FreightTable Calculation(string StartZipCode, string endZipCode)
        {
            return freightTables.Calculation(StartZipCode, endZipCode); 
        }
    }
}
