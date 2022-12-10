# SistemaDeLogin_MVC_ComEF
Login Mvc_w_RazorPages com Scaffold Identity

- Login->RazorPages:
<br/>[login.cshtml](/SistemaDeLogin_MVC_ComEF/Areas/Identity/Pages/Account/Login.cshtml)
<br/>[login.cs](/SistemaDeLogin_MVC_ComEF/Areas/Identity/Pages/Account/Login.cshtml.cs)
- Registrar->RazorPages:
<br/>[register.cshtml](/SistemaDeLogin_MVC_ComEF/Areas/Identity/Pages/Account/Register.cshtml)
<br/>[register.cs](/SistemaDeLogin_MVC_ComEF/Areas/Identity/Pages/Account/Register.cshtml.cs)

- Codigos utilizados: C#, Html, cshtml.

- Nuget packages
<br/> Microsoft.AspNetCore.Identity.EntityFrameworkCore;
<br/>Microsoft.EntityFrameworkCore.SqlServer;
<br/>Microsoft.AspNetCore.Identity.UI;
<br/>Microsoft.EntityFrameworkCore.Tools;

- Passos
<br/>*Em Model:
<br/>criar model ApplicationDbContext : IdentityDbContext
<br/>Add Scaffold Identity //Com Razor para implementar funçoes identity de login para a soluçã
<br/>*Em Program.cs:
<br/>em builder.Services adicionar builder.Services.AddRazorPages() para aceitar RazorPages
<br/>adicionar app.MapRazorPages();
<br/>em builder.Services adicionar builder.Services.AddDbContext<ApplicationDbContext>..; para conexão com o banco
<br/>adicionar app.UseAuthentication(); para habilittar autenticação
- EntityFramerwork.tools
<br/>Add-Migration "nome" -> Update-Database
