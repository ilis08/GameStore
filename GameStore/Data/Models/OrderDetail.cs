namespace GameStore.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public int GameId { get; set; }
        public int Price { get; set; }
        public virtual Game game { get; set; }
        public virtual Order order { get; set; }

        
    }
}