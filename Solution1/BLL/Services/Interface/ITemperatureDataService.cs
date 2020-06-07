using System;
using System.Collections.Generic;
using System.Text;
using BLL.DTO;

namespace BLL.Services.Interface
{
    interface ITemperatureDataService
    {
        IEnumerable<TemperatureDataDTO> GetStreets(int page);
    }
}
