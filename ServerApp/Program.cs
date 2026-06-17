var builder = WebApplication.CreateBuilder(args);

// ✨ فعال‌سازی CORS برای اجازه دسترسی از کلاینت
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());


var products = new[]
{
    new { Id = 1, Name = "Laptop", Price = 1200.50, Stock = 25, Category = new { Id = 101, Name = "Electronics" } },
    new { Id = 2, Name = "Headphones", Price = 50.00, Stock = 100, Category = new { Id = 102, Name = "Accessories" } },
    new { Id = 3, Name = "Mouse", Price = 25.00, Stock = 200, Category = new { Id = 103, Name = "Accessories" } }
};

// ✨ مسیر API با کشینگ
app.MapGet("/api/productlist", () => products);
app.Run();
