using BlazorTutorial.Components;

// This line creates the web app
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

// This line builds the web app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

// Redirects to HTTPS
app.UseHttpsRedirection();

// Adds middleware for protection
app.UseStaticFiles();
app.UseAntiforgery();

// Allows interactive server mode
app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();
