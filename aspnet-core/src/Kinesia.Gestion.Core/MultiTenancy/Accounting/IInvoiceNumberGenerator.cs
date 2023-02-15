﻿using System.Threading.Tasks;
using Abp.Dependency;

namespace Kinesia.Gestion.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}