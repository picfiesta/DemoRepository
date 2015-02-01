<%@ Application Language="C#" %>
<%@ Import Namespace="DemoRepository.UI" %>
<%@ Import Namespace="System.Web.Optimization" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        WebApiConfig.Register(System.Web.Http.GlobalConfiguration.Configuration);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        AuthConfig.RegisterOpenAuth();
        DemoRepository.Infrastructure.BLContainer.Initialize();
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

</script>
