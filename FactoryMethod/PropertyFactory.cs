namespace FactoryMethod
{
    public static class PropertyFactory
    {
        public static IProperty Build(int floors)
        {
            switch (floors)
            {
                case 1:
                    return new Bungalow();
                case 2:
                case 3:
                    return new House();
                default:
                    return new Tower();

            }
        }
    }
}
