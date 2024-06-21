using System.Collections.Generic;

namespace Proofity
{
    public class NDFormat : ProofFormat
    {
        public new CheckType CheckType = CheckType.ND;
        public List<Line> Premises;
        public Line Goal;
        public List<Line> Proof;

        public NDFormat(List<Line> premises, Line goal, List<Line> proof)
        {
            Premises = premises;
            Goal = goal;
            Proof = proof;
        }
    }
}