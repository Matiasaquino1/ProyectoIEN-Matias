using FluentValidation;
using FluentValidation.AspNetCore;
using InstitutoIENService.Infrastructure.Filters;
using InstitutoIENServices.Api;

var builder = WebApplication.CreateBuilder(args);

//add services dependencyInjection llamo al método AddService de la clase creada llamada DenpendencyInjection
builder.Services.AddService(builder.Configuration);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddControllers().AddNewtonsoftJson(option =>
{
    option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});



//automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//validation filter
builder.Services.AddMvc(option =>
{
    option.Filters.Add<ValidationFilter>();
});
    
    
//    .AddFluentValidation(option =>
//{
//    option.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
//});

// After migration:
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());// AddValidatorsFromAssemblyContaining<MyValidator>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
