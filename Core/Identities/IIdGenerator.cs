using System;

namespace Core.Identities;

public interface IIdGenerator
{
    Guid New();
}