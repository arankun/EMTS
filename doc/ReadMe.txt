This folder contains the external/vendor/thirdparty libraries.

Nuget Install Packages:

update-package Microsoft.AspNet.WebApi App.Web.Api
install-package automapper App.Common
install-package log4net App.Common
install-package nhibernate App.Data.SqlServer
install-package fluentnhibernate App.Data.SqlServer
install-package automapper App.Web.Api
install-package log4net App.Web.Api
install-package nhibernate App.Web.Api
install-package fluentnhibernate App.Web.Api
install-package Ninject.Web.Common.WebHost App.Web.Api
install-package log4net App.Web.Common
install-package nhibernate App.Web.Common
install-package ninject App.Web.Common
install-package ninject.web.common App.Web.Common


#alternate to nhibernate:

Install-Package EntityFramework -Version 6.1.2 App.Data.SqlServer

Install-Package EntityFramework -Version 6.1.2 App.Web.Api
