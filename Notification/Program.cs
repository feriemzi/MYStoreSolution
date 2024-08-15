var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//add swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//add Controllers
builder.Services.AddControllers();
var app = builder.Build();
//add automapper
//builder.Services.AddAutoMapper();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//for use controllers for routing 
app.MapControllers();

app.Run();

