using myfinance_web_netcore;
using myfinance_web_netcore.Adapters.Repositories.Interfaces;
using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.Services;
using myfinance_web_netcore.UseCases.Interfaces;
using myfinance_web_netcore.UseCases;
using myfinance_web_netcore.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyFinanceDbContext>();

// UseCases Plano Conta
builder.Services.AddScoped<IConsultaPlanoContaUseCase, ConsultaPlanoContaUseCase>();
builder.Services.AddScoped<ICadastroPlanoContaUseCase, CadastroPlanoContaUseCase>();
builder.Services.AddScoped<IExcluiPlanoContaUseCase, ExcluiPlanoContaUseCase>();

// Service Plano Conta
builder.Services.AddScoped<IPlanoContaService, PlanoContaService>();

// Reposiitory Plano Conta
builder.Services.AddScoped<IPlanoContaRepository, PlanoContaRepository>();

// UseCases Transacao
builder.Services.AddScoped<IConsultaTransacaoUseCase, ConsultaTransacaoUseCase>();
builder.Services.AddScoped<ICadastroTransacaoUseCase, CadastroTransacaoUseCase>();
builder.Services.AddScoped<IExcluiTransacaoUseCase, ExcluiTransacaoUseCase>();

// Service Transacao
builder.Services.AddScoped<ITransacaoService, TransacaoService>();

// Repository Transacao
builder.Services.AddScoped<ITransacaoRepository, TransacaoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
