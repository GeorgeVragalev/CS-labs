using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAuthentication.Ciphers;
using WebAuthentication.Models;

namespace WebAuthentication.Controllers;

[Authorize]
public class PlayfairCipherController : Controller
{
    public ActionResult PlayfairCipher()
    {
        return View();
    }

    [HttpPost]
    public ActionResult PlayfairResult(GeneralCipherModel model)
    {
        var cipher = new Playfair(model.Key, model.PlainText);

        var cipherText = cipher.Encipher();

        var plainText = cipher.Decipher();
        model.CipherText = cipherText;
        model.PlainText = plainText;

        return View(model);
    }
}