using Emts.Common;
using Emts.Common.Logging;
using FluentNHibernate.Cfg;
using log4net.Config;
using Ninject;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using Ninject.Activation;
using Ninject.Web.Common;
using Emts.Data.SqlServer.Mapping;
using Emts.Web.Common;
using Emts.Web.Common.Security;
using Emts.Data.SqlServer.QueryProcessors;
using Emts.Data.QueryProcessors;
using Emts.Common.TypeMapping;
using Emts.Web.Api.AutoMappingConfiguration;
using Emts.Web.Api.MaintenanceProcessing;

namespace App.Web.Api {
    public class NinjectConfigurator {
        public void Configure(IKernel container) {
            AddBindings(container);
        }

        private void AddBindings(IKernel container) {
            ConfigureLog4net(container);
            ConfigureUserSession(container);
            ConfigureNHibernate(container);
            ConfigureAutoMapper(container);
            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();

            container.Bind<IAddEventQueryProcessor>().To<AddEventQueryProcessor>().InRequestScope();

            container.Bind<IAddEventMaintenanceProcessor>().To<AddEventMaintenanceProcessor>()
        .InRequestScope();
        }

        private void ConfigureLog4net(IKernel container) {
            XmlConfigurator.Configure();

            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }

        private void ConfigureNHibernate(IKernel container) {
            var sessionFactory = Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(

                    c => c.FromConnectionStringWithKey("EmtsDb")))
                .CurrentSessionContext("web")
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EventMap>())
                .BuildSessionFactory();

            container.Bind<ISessionFactory>().ToConstant(sessionFactory);
            container.Bind<ISession>().ToMethod(CreateSession).InRequestScope();
            container.Bind<IActionTransactionHelper>().To<ActionTransactionHelper>().
    InRequestScope();
        }

        private void ConfigureUserSession(IKernel container) {
            var userSession = new UserSession();
            container.Bind<IUserSession>().ToConstant(userSession).InSingletonScope();
            container.Bind<IWebUserSession>().ToConstant(userSession).InSingletonScope();
        }


        private void ConfigureAutoMapper(IKernel container) {
            container.Bind<IAutoMapper>().To<AutoMapperAdapter>().InSingletonScope();

            container.Bind<IAutoMapperTypeConfigurator>()
                .To<UserEntityToUserAutoMapperTypeConfigurator>()
                .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
                .To<UserToUserEntityAutoMapperTypeConfigurator>()
                .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
                .To<NewTaskToTaskEntityAutoMapperTypeConfigurator>()
                .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
                .To<EventEntityToEventAutoMapperTypeConfigurator>()
                .InSingletonScope();
        }

        private ISession CreateSession(IContext context) {
            var sessionFactory = context.Kernel.Get<ISessionFactory>();
            if (!CurrentSessionContext.HasBind(sessionFactory)) {
                var session = sessionFactory.OpenSession();
                CurrentSessionContext.Bind(session);
            }

            return sessionFactory.GetCurrentSession();
        }
    }
}