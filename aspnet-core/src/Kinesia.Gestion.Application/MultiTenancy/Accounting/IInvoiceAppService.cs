using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Kinesia.Gestion.MultiTenancy.Accounting.Dto;

namespace Kinesia.Gestion.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
