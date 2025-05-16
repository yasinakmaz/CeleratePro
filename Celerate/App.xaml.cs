namespace Celerate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@32392e302e303b32393bJ5lxe83Y1Z1DOIMV5nMCL0FeD6AwA8Vtv8QLe9hA7Ag=");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}