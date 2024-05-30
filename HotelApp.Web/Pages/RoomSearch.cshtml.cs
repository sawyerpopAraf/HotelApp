using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace HotelApp.Web.Pages
{
    public class RoomSearchModel : PageModel
    {
        private readonly IDatabaseData _db;

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        [BindProperty(SupportsGet = true)]
        public bool SearchEnabled { get; set; } = false;

        public List<RoomTypeModel> AvailableRoomTypes { get; set; }

        public RoomSearchModel(IDatabaseData db)
        {
            _db = db;
        }

        public void OnGet()
        {
            if (SearchEnabled)
            {
                // Parse dates manually to ensure correct format
                if (Request.Query.ContainsKey("StartDate"))
                {
                    DateTime.TryParseExact(Request.Query["StartDate"], "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime startDate);
                    StartDate = startDate;
                }

                if (Request.Query.ContainsKey("EndDate"))
                {
                    DateTime.TryParseExact(Request.Query["EndDate"], "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime endDate);
                    EndDate = endDate;
                }

                AvailableRoomTypes = _db.GetAvailableRoomTypes(StartDate, EndDate);
            }
        }

        public IActionResult OnPost()
        {
            return RedirectToPage(new 
            { SearchEnabled = true,
                StartDate=StartDate.ToString("yyyy-MM-dd"), 
                EndDate=EndDate.ToString("yyyy-MM-dd") });
        }
    }
}
