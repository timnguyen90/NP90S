﻿using NP90S.Domain.Common;

namespace NP90S.Domain.Entities
{
    public class Artist :AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
