﻿using System;
using Abp;

namespace Kinesia.Gestion.Authorization.Users.Dto
{
    public class ImportUsersFromExcelJobArgs
    {
        public int? TenantId { get; set; }

        public Guid BinaryObjectId { get; set; }

        public UserIdentifier User { get; set; }
    }
}
