using Ostblock.Cryptography.Transposition.Interfaces;

namespace Ostblock.Cryptography.Transposition
{
    public class PrimitiveAlgorithmType<TType> : IInitialVector<TType>
    {
        public PrimitiveAlgorithmType(TType value)
        {
            IntialVector = value;
        }

        public TType IntialVector
        {
            get; set; 
        }
    }
}