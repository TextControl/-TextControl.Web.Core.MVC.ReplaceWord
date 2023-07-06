using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tx_replace_word.Models;

namespace tx_replace_word.Controllers {
	public class HomeController : Controller {

		public IActionResult Index() {
			return View();
		}

		[HttpGet]
		public IActionResult ReplaceWord(string word) {

			Dictionary<string, string> dict = new Dictionary<string, string>()
			{
				 { "Word1", "<strong>Formatted</strong> replacement for <em>Word1</em>" },
				 { "Word2", "<strong>Formatted</strong> replacement for <em>Word2</em>" },
				 { "Word3", "<strong>Formatted</strong> replacement for <em>Word3</em>" }
			};

			return dict.ContainsKey(word) ? Ok(dict[word]) : Ok(null);
		}

	}
}