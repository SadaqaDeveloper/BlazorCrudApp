namespace BlazorCrudApp.Services
{
    public class ProductListState
    {
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        public string SearchText { get; set; } = string.Empty;

        public string SortColumn { get; set; } = "Id";
        public bool SortAsc { get; set; } = false;
    }
}
