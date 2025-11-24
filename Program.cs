using ServiceLifetimeDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//// ---------------------
// REGISTER LIFETIME SERVICES
//// ---------------------

// New instance on every request
builder.Services.AddTransient<TransientGuidService>();

// One instance per HTTP request
builder.Services.AddScoped<ScopedGuidService>();

// One instance for the whole app lifetime
builder.Services.AddSingleton<SingletonGuidService>();

//// ---------------------

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enables wwwroot (index.html)
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();


