namespace MobileAppBuilder
{
    public class MobileAppDirector
    {
        private MobileAppBuilder _mobileAppBuilder;

        public void SetBuilder(MobileAppBuilder mobileAppBuilder)
        {
            _mobileAppBuilder = mobileAppBuilder;
        }

        public MobileApp BuildApp()
        {
            _mobileAppBuilder.CreateNewMobileApp();
            _mobileAppBuilder.SetName();
            _mobileAppBuilder.SetPlatform();
            _mobileAppBuilder.AddAuthentication();
            _mobileAppBuilder.AddPushNotifications();
            _mobileAppBuilder.AddPaymentIntegration();
            return _mobileAppBuilder.GetMobileApp();
        }
    }
}
