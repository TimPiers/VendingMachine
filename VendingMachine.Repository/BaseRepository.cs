using System;

namespace VendingMachine.Repository
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {

        public MachineContext CreateContext()
        {
            return new MachineContext();
        }

    }
 }
