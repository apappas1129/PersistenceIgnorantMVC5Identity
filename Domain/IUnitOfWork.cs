using Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        IExternalLoginRepository ExternalLoginRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }

        #endregion


        #region Methods

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #endregion
    }
}
