namespace UstaPlatform.Infrastructure
{
    public static class Guard
    {
        public static void AgainstNull(object? obj, string paramName)
        {
            if (obj is null)
                throw new ArgumentNullException(paramName);
        }
    }
}
