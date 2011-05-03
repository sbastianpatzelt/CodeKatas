namespace Ostblock.Cryptography.Transposition.Interfaces
{
    public interface IInitialVector<TIntialVectorType>
    {
        TIntialVectorType IntialVector
        {
            get;
            set;
        }
    }
}