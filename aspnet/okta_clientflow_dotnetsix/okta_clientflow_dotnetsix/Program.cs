using okta_clientflow_dotnetsix.Okta;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Added in order to catch the information from the appsettings.json file under the Okta section
builder.Services.Configure<OktaJwtVerificationOptions>(builder.Configuration.GetSection("Okta"));

// Added as normally required by the dependency injection mechanism
builder.Services.AddTransient<IJwtValidator, OktaJwtValidation>();

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
