This folder contains the external/vendor/thirdparty libraries.

1. Nuget Install Packages:

update-package Microsoft.AspNet.WebApi Emts.Web.Api
install-package automapper Emts.Common
install-package log4net Emts.Common
install-package nhibernate Emts.Data.SqlServer
install-package fluentnhibernate Emts.Data.SqlServer
#??? install-package automapper Emts.Web.Api 
install-package log4net Emts.Web.Api
install-package nhibernate Emts.Web.Api
install-package fluentnhibernate Emts.Web.Api
install-package Ninject.Web.Common.WebHost Emts.Web.Api
install-package log4net Emts.Web.Common
install-package nhibernate Emts.Web.Common
install-package ninject Emts.Web.Common
install-package ninject.web.common Emts.Web.Common
install-package automapper Emts.Common

#alternate to nhibernate:

Install-Package EntityFramework -Version 6.1.2 Emts.Data.SqlServer

Install-Package EntityFramework -Version 6.1.2 Emts.Web.Api

2. install-package Microsoft.AspNet.WebApi Emts.Web.Common

3. Diagnostic Tracing
install-package Microsoft.AspNet.WebApi.Tracing Emts.Web.Api