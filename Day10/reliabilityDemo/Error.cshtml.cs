using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ReliabilityDemo2.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public int StatusCode {  get; set; }
        //public string? RequestId { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int code)
        {

            // RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            StatusCode = code;
            if (code == 500)
            {
                _logger.LogError("A 500 Internal Server Error Occured");
            }
            else if(code==404)
            {
                _logger.LogError("A 404 Not found error occured");
            }
            else
            {
                _logger.LogInformation("error with status code {StatusCode} occured",StatusCode);
            }
;        }
    }

}
