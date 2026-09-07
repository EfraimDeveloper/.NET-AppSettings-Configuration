using Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Appsetings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddTransient<Service>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var service = app.Services.GetRequiredService<Service>();
service.ShowAppsetings();

app.Run();
