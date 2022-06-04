using DAL;
using Microsoft.AspNetCore.Authentication.Cookies;
using RealizationProvider;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


//dependency injection
var _servicess = serviceProviderrr.Get();
IServiceProvider _provider = _servicess.BuildServiceProvider();
var _userDB = _provider.GetService<IUserDB>();
var _gameDB = _provider.GetService<IGameDB>();
var _tournamentDB = _provider.GetService<ITournamentDB>();
builder.Services.AddSingleton<IUserDB>(_userDB);
builder.Services.AddSingleton<IGameDB>(_gameDB);
builder.Services.AddSingleton<ITournamentDB>(_tournamentDB);

//System.Diagnostics.Debug.WriteLine(_orderDB.GetType().Name);
//string a = _orderDB.GetType().Name;

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = new PathString("/login");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();