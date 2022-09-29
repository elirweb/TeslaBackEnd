using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Domain.Interfaces
{
    public interface IFreightTable
    {
        Domain.FreightTable Calculation(string StartZipCode, string endZipCode);
    }
}
