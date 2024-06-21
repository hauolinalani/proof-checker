using System.Collections.Generic;

namespace Proofity
{
    public class ZFormat : ProofFormat
    {
        public new CheckType CheckType = CheckType.Z;
        public List<Line> Spec;

        public ZFormat(List<Line> spec)
        {
            Spec = spec;
        }
    }
}