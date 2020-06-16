namespace Web.ViewModels
{
    public class PaginationInfoViewModel
    {
        public int TotalItems { get; set; }
        public int ItemsOnPage { get; set; }
        public int ActualPage { get; set; }
        public int TotalPages { get; set; }
    }
}
