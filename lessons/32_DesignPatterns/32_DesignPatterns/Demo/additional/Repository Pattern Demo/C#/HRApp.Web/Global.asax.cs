using System;
using System.ServiceModel.DomainServices;
using HRApp.Web.Repository;
using System.ServiceModel.DomainServices.Server;

namespace HRApp.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            DomainService.Factory = new OrganizationDomainServiceFactory();               
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            DomainService.Factory = null; 
        }
    }
}