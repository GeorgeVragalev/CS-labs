using PasswordHashing_DigitalSignatures.Model;

namespace PasswordHashing_DigitalSignatures.DB;

public interface IUserStorage
{
    public User? GetByName(string name);
    public void Save(User entity);
    public IList<User?> GetAll();
}