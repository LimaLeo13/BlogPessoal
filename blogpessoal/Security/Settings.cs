namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "72ff8c80963faaa3489b705e8a07c713ba8369612b96050744803faf9fa12c43";

        public static string Secret { get => secret; set => secret = value; }

    }
}