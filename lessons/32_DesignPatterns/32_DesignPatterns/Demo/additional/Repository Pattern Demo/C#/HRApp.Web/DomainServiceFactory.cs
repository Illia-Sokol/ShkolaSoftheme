using System;
using System.ServiceModel.DomainServices.Server;

namespace HRApp.Web.Repository
{
    //Factory class responsible for creating DomainService
public class OrganizationDomainServiceFactory : IDomainServiceFactory
{
    public DomainService CreateDomainService(Type domainServiceType, DomainServiceContext context)
    {
        AdventureWorksDataContext ctxt = new AdventureWorksDataContext();
        IRepository<Employee> empRepository = new LinqToSqlRepository<Employee>(ctxt);
        DomainService ds = (DomainService)Activator.CreateInstance(domainServiceType, new object[] { empRepository });
        ds.Initialize(context);
        return ds;
    }

    public void ReleaseDomainService(DomainService domainService)
    {
    }
}
}
