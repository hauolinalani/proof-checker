namespace Proofity
{
    public class BinaryAST
    {
        public Token Token;
        public BinaryAST left;
        public BinaryAST right;

        public BinaryAST(Token token)
        {
            Token = token;
        }

    }
}