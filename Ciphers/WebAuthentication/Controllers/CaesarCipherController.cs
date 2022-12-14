using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAuthentication.Ciphers;
using WebAuthentication.Models;

namespace WebAuthentication.Controllers;

[Authorize]
public class CaesarCipherController : Controller
{
    public ActionResult CaesarCipher()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult CaesarResult(CaesarCipherModel cipher)
    {
        var caesarCipher = new Caesar(cipher.PlainText, cipher.Key);
        
        var cipherText = caesarCipher.Encipher();

        var plainText = caesarCipher.Decipher();
        cipher.CipherText = cipherText;
        cipher.PlainText = plainText;

        return View(cipher);
    }
}