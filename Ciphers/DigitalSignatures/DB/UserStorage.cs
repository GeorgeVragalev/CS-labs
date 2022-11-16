using Ciphers.DigitalSignatures.Model;

namespace Ciphers.DigitalSignatures.DB;

public class UserStorage : IUserStorage
{
    private readonly IList<User?> _users;


    public UserStorage(IList<User?> users)
    {
        _users = users;
    }

    public User? GetByName(string name)
    {
        if (_users.Count == 0)
        {
            return null;
        }

        return _users.FirstOrDefault(u => u.UserName.Equals(name));
    }

    public void Save(User entity)
    {
        _users.Add(entity);
    }

    public IList<User?> GetAll()
    {
        return _users;
    }
}