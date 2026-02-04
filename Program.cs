var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<project_template.Services.HelloWorldService>();
builder.Services.AddScoped<project_template.Services.AskingQuestionsService>();
builder.Services.AddScoped<project_template.Services.AddingTwoNumbersService>();
builder.Services.AddScoped<project_template.Services.MadLibService>();
builder.Services.AddScoped<project_template.Services.OddOrEvenService>();
builder.Services.AddScoped<project_template.Services.ReverseService>();
builder.Services.AddScoped<project_template.Services.ReverseNumbersService>();
builder.Services.AddScoped<project_template.Services.Magic8BallService>();
builder.Services.AddSingleton<project_template.Services.GuessItService>();
builder.Services.AddScoped<project_template.Services.RestaurantPickerService>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
