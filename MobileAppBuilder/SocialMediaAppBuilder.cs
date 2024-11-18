namespace MobileAppBuilder
{
    public class SocialMediaAppBuilder : MobileAppBuilder
    {
        public override void SetName()
        {
            MobileApp.Name = "Social Media App";
        }

        public override void SetPlatform()
        {
            MobileApp.Platform = "iOS";
        }

        public override void AddAuthentication()
        {
            MobileApp.HasAuthentication = true;
        }

        public override void AddPushNotifications()
        {
            MobileApp.HasPushNotifications = true;
        }

        public override void AddPaymentIntegration()
        {
            MobileApp.HasPaymentIntegration = false; // Social media apps typically don’t need payment integration.
        }
    }
}
