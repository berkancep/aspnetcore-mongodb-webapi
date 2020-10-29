using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.API.Models
{
    public interface IBaseEntity
    {
         string Id { get; set; }
    }
}
