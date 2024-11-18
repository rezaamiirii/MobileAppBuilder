namespace MobileAppBuilder
{
    public class MobileApp
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public bool HasAuthentication { get; set; }
        public bool HasPushNotifications { get; set; }
        public bool HasPaymentIntegration { get; set; }

        public override string ToString()
        {
            return $"App Name: {Name}\n" +
               $"Platform: {Platform}\n" +
               $"Authentication: {HasAuthentication}\n" +
               $"Push Notifications: {HasPushNotifications}\n" +
               $"Payment Integration: {HasPaymentIntegration}\n";
        }
    }
}
