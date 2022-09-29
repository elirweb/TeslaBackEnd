using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.DomainService.Interfaces
{
    public interface IFreightTables
    {
        Domain.Domain.FreightTable Calculation(string StartZipCode, string endZipCode);
    }
}
