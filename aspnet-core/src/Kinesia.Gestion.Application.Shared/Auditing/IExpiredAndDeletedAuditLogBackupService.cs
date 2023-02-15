using System.Collections.Generic;
using Abp.Auditing;

namespace Kinesia.Gestion.Auditing
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();
        
        void Backup(List<AuditLog> auditLogs);
    }
}