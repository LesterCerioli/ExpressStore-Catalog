using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressStore.Infrastructure.Catalog.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
