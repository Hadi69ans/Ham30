namespace Ham30.Server.Services.Common
{
    public abstract class PagedRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public string[] Orderby { get; set; }
    }
}