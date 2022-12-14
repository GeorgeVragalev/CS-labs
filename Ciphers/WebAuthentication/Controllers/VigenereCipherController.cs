using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAuthentication.Ciphers;
using WebAuthentication.Models;

namespace WebAuthentication.Controllers;

[Authorize]
public class VigenereCipherController : Controller
{
    public ActionResult VigenereCipher()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult VigenereResult(GeneralCipherModel model)
    {
        var cipher = new Vigenere(model.Key, model.PlainText);
        
        var cipherText = cipher.Encipher();

        var plainText = cipher.Decipher();
        model.CipherText = cipherText;
        model.PlainText = plainText;

        return View(model);
    }
}