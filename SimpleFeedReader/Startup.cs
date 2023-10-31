
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleFeedReader;
public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public IConfiguration Configuration { get; }

	private IMvcBuilder mvcBuiulder;

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddScoped<NewsService>();
		services.AddAutoMapper(typeof(Startup));

		mvcBuiulder = services.AddRazorPages();
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			app.UseDeveloperExceptionPage();
			mvcBuiulder.AddRazorRuntimeCompilation();
		}
		else
		{
			app.UseExceptionHandler("/Error");
		}

		app.UseStaticFiles();

		app.UseRouting();

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapRazorPages();

			endpoints.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}");

		});
	}
}
