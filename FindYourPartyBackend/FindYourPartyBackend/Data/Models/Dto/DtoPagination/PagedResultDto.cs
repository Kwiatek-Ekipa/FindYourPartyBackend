namespace FindYourPartyBackend.Data.Models.Dto.DtoPagination
{
    public class PagedResultDto<T>
    {
        public List<T> Items { get; set; }
        public int TotalPages { get; set; }
        public int ItemsFrom { get; set; }
        public int ItemsTo { get; set; }
        public int TotalItemsCount { get; set; }

        public PagedResultDto(List<T> items, int totalItemsCount, int pageSize, int pageIndex)
        {
            if (pageSize == -1)
            {
                Items = items;
                TotalItemsCount = totalItemsCount;
                ItemsFrom = 1;
                ItemsTo = totalItemsCount;
                TotalPages = 1;
            }
            else
            {
                Items = items;
                TotalItemsCount = totalItemsCount;
                ItemsFrom = pageSize * (pageIndex - 1) + 1;
                ItemsTo = ItemsFrom + pageSize - 1;
                TotalPages = (int)Math.Ceiling(totalItemsCount / (double)pageSize);
            }
        }
    }
}
