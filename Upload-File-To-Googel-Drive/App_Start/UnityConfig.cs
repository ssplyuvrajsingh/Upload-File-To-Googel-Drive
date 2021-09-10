using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Upload_File_To_Googel_Drive.DIServices;

namespace Upload_File_To_Googel_Drive
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IGoogleDrive, GoogleDriveService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}