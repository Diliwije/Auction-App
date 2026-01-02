namespace AuctionApi.Dto
{
    public class AuctionItemDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal StartingPrice { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
