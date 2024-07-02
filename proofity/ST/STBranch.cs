using System.Collections.Generic;

namespace Proofity
{
    public class STBranch: ISTEntry
    {
        public List<ISTEntry> children;

        public STEntryType entryType()
        {
            return STEntryType.Branch;
        }

    }
}