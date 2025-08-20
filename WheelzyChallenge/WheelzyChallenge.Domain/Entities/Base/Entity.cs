using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Interfaces;

namespace WheelzyChallenge.Domain.Entities.Base
{
    [Serializable]
    public abstract class Entity : Entity<int>, IEntity<int>
    {
    }

    [Serializable]
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
