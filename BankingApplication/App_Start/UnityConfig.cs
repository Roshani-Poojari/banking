using BankingApplication.Data;
using NHibernate;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace BankingApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ISession>(new InjectionFactory(c => NHibernateHelper.CreateSession()));

            

            //container.RegisterType<IPaymentService, PaymentService>();
            //container.RegisterType<IPaymentRepository, PaymentRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}