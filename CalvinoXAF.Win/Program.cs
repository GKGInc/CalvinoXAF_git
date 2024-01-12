using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using System.ServiceModel;
using DevExpress.ExpressApp.Security.ClientServer.Wcf;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.XtraEditors;

namespace CalvinoXAF.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.Latest;
#if EASYTEST
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif
            WindowsFormsSettings.LoadApplicationSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			DevExpress.Utils.ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            if(Tracing.GetFileLocationFromSettings() == DevExpress.Persistent.Base.FileLocation.CurrentUserApplicationDataFolder) {
                Tracing.LocalUserAppDataPath = Application.LocalUserAppDataPath;
            }
            Tracing.Initialize();
            CalvinoXAFWindowsFormsApplication winApplication = new CalvinoXAFWindowsFormsApplication();
            //winApplication.GetSecurityStrategy().RegisterXPOAdapterProviders();
            //SecurityAdapterHelper.Enable();

            if (ConfigurationManager.ConnectionStrings["ConnectionString"] != null)
            {
                winApplication.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached && winApplication.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema)
            {
                winApplication.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
#endif
            try
            {
                ////string connectionString = "net.tcp://127.0.0.1:54922/DataServer";
                //WcfSecuredClient wcfSecuredClient = new WcfSecuredClient(WcfDataServerHelper.CreateNetTcpBinding(), new EndpointAddress(winApplication.ConnectionString));
                //MiddleTierClientSecurity security = new MiddleTierClientSecurity(wcfSecuredClient);
                //security.IsSupportChangePassword = true;
                //winApplication.Security = security;
                //winApplication.CreateCustomObjectSpaceProvider += (s, e) =>
                //{
                //    e.ObjectSpaceProviders.Add(new MiddleTierServerObjectSpaceProvider(wcfSecuredClient));
                //    e.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(winApplication.TypesInfo, null));
                //};

                winApplication.Setup();
                winApplication.Start();
                //wcfSecuredClient.Dispose();
            }
            catch(Exception e) {
                winApplication.StopSplash();
                winApplication.HandleException(e);
            }
        }
    }
}
