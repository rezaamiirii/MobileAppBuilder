using MobileAppBuilder;

var director = new MobileAppDirector();


// Build an E-commerce App
var ecommerceBuilder = new EcommerceAppBuilder();
director.SetBuilder(ecommerceBuilder);
MobileApp ecommerceApp = director.BuildApp();
Console.WriteLine("E-Commerce App Built:\n" + ecommerceApp);

// Build a Social Media App
var socialMediaBuilder = new SocialMediaAppBuilder();
director.SetBuilder(socialMediaBuilder);
MobileApp socialMediaApp = director.BuildApp();
Console.WriteLine("Social Media App Built:\n" + socialMediaApp);