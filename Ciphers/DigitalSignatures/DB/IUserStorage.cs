using Ciphers.DigitalSignatures.Model;

namespace Ciphers.DigitalSignatures.DB;

public interface IUserStorage
{
    public User? GetByName(string name);
    public void Save(User entity);
    public IList<User?> GetAll();
}