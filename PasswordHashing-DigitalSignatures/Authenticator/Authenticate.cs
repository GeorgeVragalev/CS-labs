using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using PasswordHashing_DigitalSignatures.DB;
using PasswordHashing_DigitalSignatures.DSE;
using PasswordHashing_DigitalSignatures.Helpers;
using PasswordHashing_DigitalSignatures.Model;

namespace PasswordHashing_DigitalSignatures.Authenticator;

public class Authenticate : IAuthenticate
{
    private readonly PasswordHasher _passwordHasher;
    private readonly IUserStorage _userStorage;
    private readonly IDSE _dse;
    
    public Authenticate(PasswordHasher passwordHasher, UserStorage userStorage, IDSE dse)
    {
        _passwordHasher = passwordHasher;
        _userStorage = userStorage;
        _dse = dse;
    }

    public void Register()
    {
        Console.Write("Enter a username: ");
        string? username = Console.ReadLine();

        Console.Write("Enter a password: ");
        string? password = Console.ReadLine();

        // Hash
        var hash = _passwordHasher.Hash(password);

        var user = new User()
        {
            Id = IdGenerator.GenerateId(),
            UserName = username,
            Password = hash,
            Message = ""
        };

        // Verify
        var result = _passwordHasher.Verify(password, user.Password);
        Console.WriteLine($"Hashed: {user.Password}");
        Console.WriteLine($"The password is: {(result ? "" : "not")} valid");

        _userStorage.Save(user);

        var users = _userStorage.GetAll();
        foreach (var u in users)
        {
            u.GetDetails();
        }
    }

    public User Login()
    {
        Console.Write("Enter a username: ");
        string? username = Console.ReadLine();

        if (username == null)
        {
            return null;
        }

        var user = _userStorage.GetByName(username);
        if (user == null)
        {
            Console.Write($"User with username {username} doesn't exists.");
            return null;
        }

        Console.Write("Enter a password: ");
        string? password = Console.ReadLine();

        // Verify
        var result = _passwordHasher.Verify(password, user?.Password);
        Console.WriteLine($"Hash: {user.Password}");
        Console.WriteLine($"The password is: {(result ? "" : "not")} valid");
        Console.WriteLine($"Authentication {(result ? "successful" : "failed")}!");

        return user;
    }
    
    public void SetDigitalSignature(User user)
    {
        Console.Write("Enter a message: ");
        string? message = Console.ReadLine();

        if (message == null)
        {
            return;
        }

        //hash
        var hash = _passwordHasher.Hash(message);

        var encryptedHash = _dse.Encrypt(hash);
        user.Message = encryptedHash;
    }

    public void VerifyDigitalSignature(User user)
    {
        Console.Write("Enter a message: ");
        string? message = Console.ReadLine();

        var decryptedHash = _dse.Decrypt(user.Message);

        // Verify
        var result = _passwordHasher.Verify(message, decryptedHash);
        Console.WriteLine($"Hash: {user.Message}");
        Console.WriteLine($"The message is: {(result ? "" : "not")} valid");
        Console.WriteLine($"Digital signature check {(result ? "successful" : "failed")}!");
    }

}