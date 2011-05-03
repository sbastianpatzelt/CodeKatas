namespace Ostblock.Cryptography.Transposition.Interfaces
{
    public interface IAlgorithm<TInitialVectorType>
    {
        IInitialVector<TInitialVectorType> InitialVector
        {
            get;
            set;
        }
        string Decrypt(string secretText);
        string Encrypt(string clearText);

    }
}