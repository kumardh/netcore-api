# CI/CD pipeline for .NET Core with the Azure DevOps Project

The **Azure DevOps Project** simplifies the initial configuration of a
continuous integration (CI) and continuous delivery (CD) pipeline for your .NET
core or ASP.NET applications

**What’s covered here**

-   Create ASP .NET Core Web Application

-   Add xUnit Test Project(.NET Core)

-   Add Azure Web App

-   Create new Azure DevOps project

-   Configure **Azure DevOps Project** CI/CD pipelines

-   Commit the code changes and execute CI/CD

-   Test Web Api

### Create ASP .NET Core Web Application

Add ASP .NET Core Web Application(netcore-api). Added VersionController to the
project that return application name, version, hosting, process name and app
settings used in the application.

![](media/43ff5690482f7da9a918510411a430a4.png)

### Add a xUnit Test Project to solution

Next, Add a xUnit Test Project to solution and add couple of test to it. This
will be integrated with CI/CD. If you look and the project templates you can see
other test templates like MSTest and NUnit. **xUnit** is pretty lean compared
to **NUnit** and MsTest and has been written more recently. The .NET framework
has evolved since **NUnit**was first created.**XUnit** leverage some of the new
features to help developers write cleaner test, as tests should be kept clean
and treated as first-class citizens.follow this [link
](https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/multi-container-microservice-net-applications/test-aspnet-core-services-web-apps)for
more info.

![](media/fb2d28e7f1a359935b47fd508c5e7345.png)

### Add Azure Web App

Next, Login to Azure portal -\> App Service -\> Web Application. And Create a
Web App where the above .NET Core application will be deployed. Select .NET Core
2.2 as runtime stack.

![](media/11b17320fa44116fa98a7cb58865ce59.png)

### Create New Azure DevOps project

Create Azure devOps project in your Organization. Reference link
<https://dev.azure.com/ManavSoft/>

![](media/9554905e0c64d3a63fd0cea517a0b8f1.png)

### Configure CI/CD Pipeline:

![](media/8964c26a44d637fbf161738a88966cf0.png)

### Configure Builds pipeline

**Repository** 

![](media/b00b28a4104fdddef6f68b87ff550838.png)

**Agent job** 

![](media/8650506978d8284f6d11fff363fc499f.png)

**Add Restore task**

![](media/a35f1b76aca3de2f59647b21ef77520f.png)

**Add Build task**

![](media/4cfceaf5c2525767e5d18448fa5a7a15.png)

**Add Test task**

![](media/8e4a1eb48f001e417020d4735fbc6719.png)

**Add Publish task**

![](media/08ddb7a8523bf8c8b99894557d6fef1c.png)

**Publish Artifact**

![](media/09bb3565e325b0bfc9fdb40b90d41a7f.png)

### Configure Release pipeline**

![](media/03eb326242886697d01cda91d68528cd.png)

![](media/f1cdb80ecfac0c8212acbcbf22177ed2.png)

**Deploy Azure App**

![](media/58559fc9406102a44db23aabf41480cf.png)

## Test Web Api 

![](media/db000dc5fbbc8aa8d8b6b20b5e1fa0b2.png)
