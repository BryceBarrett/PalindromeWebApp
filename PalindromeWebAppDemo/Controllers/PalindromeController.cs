using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using PalindromeWebAppDemo.BusinessLogic;

namespace PalindromeWebAppDemo.Controllers
{
    public class PalindromeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        // Post: /Palindrome/AllCalculations/ 
        [HttpPost]
        public IActionResult AllCalculations(string paragraph, char letter)
        {
            //not going to use a model since this is just aggregate data
            ViewData["numPalindrome"] = PalindromeHelper.CountPalindromes(paragraph);
            ViewData["numPalSentence"] = PalindromeHelper.CountPalindromeSentences(paragraph);
            ViewData["uniqueWords"] = PalindromeHelper.UniqueWords(paragraph);
            ViewData["wordsWithLetter"] = PalindromeHelper.ContainsLetter(paragraph, letter);

            return View();
        }

        public IActionResult About()
        {
            return View();
        }


    }
}
