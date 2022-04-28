using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();





//dependency injection harddd
//IServiceCollection _servicess = serviceProviderrr.Get();
//IServiceProvider _provider = _servicess.BuildServiceProvider();
//var _userDB = _provider.GetService<IuserDB>();
//var _orderDB = _provider.GetService<IorderDb>();
//var _messagesDB = _provider.GetService<ImessagesDB>();
//var _productDB = _provider.GetService<IproductDb>();
//var _specialProductDB = _provider.GetService<IspecialProductsDB>();
//builder.Services.AddSingleton<IuserDB>(_userDB);
//builder.Services.AddSingleton<IorderDb>(_orderDB);
//builder.Services.AddSingleton<ImessagesDB>(_messagesDB);
//builder.Services.AddSingleton<IproductDb>(_productDB);
//builder.Services.AddSingleton<IspecialProductsDB>(_specialProductDB);
//System.Diagnostics.Debug.WriteLine(_orderDB.GetType().Name);
//string a = _orderDB.GetType().Name;

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
        {
            options.LoginPath = new PathString("/login");

        }
    );
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