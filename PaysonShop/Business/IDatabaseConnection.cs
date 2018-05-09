namespace PaysonShop.Business
{
    public interface IDatabaseConnection
    {
        Cart Add(Cart cart);
        Cart Get(int id);
        Cart Save(Cart cart);
    }
}
