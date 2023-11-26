using InstitutoIENService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoIENService.Core.Interfaces
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<Province>> GetProvince();
    }
}
