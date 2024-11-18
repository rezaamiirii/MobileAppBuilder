namespace MobileAppBuilder
{
    public abstract class MobileAppBuilder
    {
        protected MobileApp MobileApp;

        public void CreateNewMobileApp()
        {
            MobileApp = new MobileApp();
        }

        public MobileApp GetMobileApp()
        {
            return MobileApp;
        }
        public abstract void SetName();
        public abstract void SetPlatform();
        public abstract void AddAuthentication();
        public abstract void AddPushNotifications();
        public abstract void AddPaymentIntegration();
    }
}
