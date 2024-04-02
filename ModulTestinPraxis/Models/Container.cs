using System;
using ModulTestinPraxis.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulTestinPraxis.Models
{
    public class Container : IContainer
    {
        public string Id { get; private set; }

        public Container()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

}
