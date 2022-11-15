using GameSite.Data;
using GameSite.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Westwind.AspNetCore.LiveReload;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(
	        options => {
		        options.SignIn.RequireConfirmedAccount = true;
		        options.User.RequireUniqueEmail        = true;
	        })
       .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

builder.Services.AddLiveReload();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseMigrationsEndPoint();
} else {
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseLiveReload();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseMvc(
	routes => {
		routes.MapRoute(
			"area",
			"{area:exists}/{controller=Home}/{action=Index}/{id?}");

		routes.MapRoute(
			"default",
			"{controller=Home}/{action=Index}/{id?}");
	});

app.MapRazorPages();

app.Run();