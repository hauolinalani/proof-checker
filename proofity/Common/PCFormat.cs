using System.Collections.Generic;

namespace Proofity
{
    public class PCFormat: ProofFormat
    {
        public new CheckType CheckType = CheckType.PC;
        public List<Line> Program;

        public PCFormat(List<Line> program)
        {
            Program = program;
        }
    }
}