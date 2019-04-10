using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkReadyUtility
{
    public interface IUnitOfWorkBase : IDisposable
    {
        int Complete();
    }
}
