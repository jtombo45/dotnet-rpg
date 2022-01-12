//Referencing the character services class
using dotnet_rpg.Services.CharacterService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//System.InvalidOperationException: Unable to resolve service for type 'dotnet_rpg.Services.CharacterService.ICharacterService' 
//while attempting to activate 'dotnet_rpg.Controllers.CharacterController'.
//Registering the character service to fix the commented error above
//Also make suring to add the reference at the top: using dotnet_rpg.Services.CharacterService;
//Lastly their other methods other than AddScoped: AddSingleton and AddTransient
//AddSingleton: Adds a singleton service of the type specified in serviceType to the specified IServiceCollection.
//AddTransient: Adds a transient service of the type specified in serviceType to the specified IServiceCollection.
builder.Services.AddScoped<ICharacterService, CharacterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
