using System;

namespace Proofity
{
    public abstract class PredicateType : ICloneable
    {
        public abstract object Clone();
        public abstract bool IsNull();
    }
}