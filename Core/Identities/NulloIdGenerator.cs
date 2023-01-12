using System;

namespace Core.Identities;

public class NulloIdGenerator : IIdGenerator
{
    public Guid New() => Guid.NewGuid();
}