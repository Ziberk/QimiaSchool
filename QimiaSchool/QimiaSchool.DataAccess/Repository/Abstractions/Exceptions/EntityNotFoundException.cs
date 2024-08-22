using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.DataAccess.Repository.Abstractions.Exceptions
{
    public class EntityNotFoundException<T> : Exception
    {
        public int EntityId { get; }

        public EntityNotFoundException(int entityId)
            : base(CreateExceptionMessage(entityId))
        {
            EntityId = entityId;
        }

        private static string CreateExceptionMessage(int entityId)
        {
            return $"Entity '{typeof(T).Name}' with id '{entityId}' was not found.";
        }
    }

}
