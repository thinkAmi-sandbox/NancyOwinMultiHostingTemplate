# NancyOwinMultiHostingTemplate

C# project template for creating Nancy OWIN multi-hosting projects (ASP.NET and Self Hosting, with Razor view engine).

　  
## Getting Started

##### 1. Clone or Download ZIP 

##### 2. Copy `NancyOwinMultiHosting.zip` template file to project templates folder
From `root\template\NancyMultiHosting.zip` to `%USERPROFILE%\Documents\Visual Studio 2013\Templates\ProjectTemplates` folder.

　  
##### 3. Run Visual Studio, and Create New Project
1. Click `template > Visual C#`
2. Select `NancyOwinMultiHosting`
3. (Option) Change solution/project name
4. Click OK button.

　  
##### 4. Enable NuGet Package Restore
1. Right click solution
2. Select `Enable NuGet Package Restore`.

　  
##### 5. ReInstall NuGet packages
1. If open package manager console with display message and Restore button, click Restore button. 
2. Input `Update-Package -Reinstall` command at package manager console. 

　  
## Template Details
template code is in `root\src` folder.

### Solution and projects
  
|Project Name|Project Template|Description|Project references|
|---|---|---|---|
|NancyApp|Class Library|main Nancy app|-|
|OwinAspNetHosting|ASP.NET Empty Web Application|IIS Hosting config|NancyApp|
|OwinSelfHosting|Console|Self Hosting config|NancyApp|

　  
### NuGet Packages
  
|Package|version|NancyApp|AspNet|Self|
|---|---|---|---|---|
|Nancy|1.1|o|o|o|
|Microsoft.Owin.Host.SystemWeb|3.0.1|-|-|o|
|Microsoft.Owin.Hosting|3.0.1|-|-|o|
|Microsoft.Owin.Host.HttpListener|3.0.1|-|-|o|
|Nancy.Owin|1.1|-|o|o|
|Nancy.ViewEngines.Razor|1.1|o|-|-|

　  
### Project details
#### NancyApp
##### HomeModule.cs
Display razor.cshtml view

　  
##### Bootstrapper.cs
Add `Views` as view folder by `this.Conventions.ViewLocationConventions.Add`.

Display error message by `Nancy.StaticConfiguration.DisableErrorTraces = false`.

　  
##### RazorConfig.cs
Enable razor view engine by yield return namespaces.

　  
#### OwinAspNetHosting
##### Startup.cs
See official Wiki : [Hosting nancy with owin · NancyFx/Nancy Wiki · GitHub](https://github.com/NancyFx/Nancy/wiki/Hosting-nancy-with-owin#katana---aspnet-host)

Note: it is not necessary to update `web.config`.

　  
#### OwinSelfHosting
##### Startup.cs, Program.cs
See official Wiki : [Hosting nancy with owin · NancyFx/Nancy Wiki · GitHub](https://github.com/NancyFx/Nancy/wiki/Hosting-nancy-with-owin#katana---httplistener-selfhost)

　  
##### Configuring Namespace Reservations
```
netsh http add urlacl url=http://+:8765/ user=Everyone
```

Note: as necessary, change port `8765` and user.

　  
## Tested environment
 * Windows7 x64
 * VisualStudio 2013 Community

　  
## Related Blog posts (written in Japanese), GitHub repository
- [C#で、NuGetパッケージや複数プロジェクトを含むプロジェクトテンプレートを作成する - メモ的な思考的な](http://thinkami.hatenablog.com/entry/2015/04/05/061412)
- [C# + Nancyを使って、1つのアプリでHerokuとAzure Websitesの両方へデプロイできるように構成する - メモ的な思考的な](http://thinkami.hatenablog.com/entry/2015/02/04/060331)
- [thinkAmi-sandbox/NancyOwinMutiHosting-sample · GitHub](https://github.com/thinkAmi-sandbox/NancyOwinMutiHosting-sample)

　  
## License
MIT
