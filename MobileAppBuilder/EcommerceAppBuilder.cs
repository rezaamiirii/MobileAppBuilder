namespace MobileAppBuilder
{
    public class EcommerceAppBuilder : MobileAppBuilder
    {
        public override void AddAuthentication()
        {
            MobileApp.HasAuthentication = true;
        }

        public override void AddPaymentIntegration()
        {
            MobileApp.HasPaymentIntegration = true;
        }

        public override void AddPushNotifications()
        {
            MobileApp.HasPushNotifications = true;
        }

        public override void SetName()
        {
            MobileApp.Name = "Ecommerce App";
        }

        public override void SetPlatform()
        {
            MobileApp.Platform = "Android & iOS";
        }
    }
}
