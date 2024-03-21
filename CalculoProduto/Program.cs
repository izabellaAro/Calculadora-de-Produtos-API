using CalculoProduto.Application.Services;
using CalculoProduto.Application.Services.Impl;
using CalculoProduto.DataAccess;
using CalculoProduto.DataAccess.Mappers;
using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.DataAccess.Repositories.Impl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PrecificaProdConnection");
builder.Services.AddDbContext<ProdutoContext>(opts => opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Add services to the container.
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IMateriaPrimaService,MateriaPrimaService>();
builder.Services.AddScoped<IInsumoIndiretoService, InsumoIndiretoService>();
builder.Services.AddScoped<IPreparacaoService, PreparacaoService>();

// Add repositories
builder.Services.AddScoped<IInsumoIndiretoRepository, InsumoIndiretoRepository>();
builder.Services.AddScoped<IMateriaPrimaRepository, MateriaPrimaRepository>();
builder.Services.AddScoped<IInsumoIndiretoRepository, InsumoIndiretoRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IPreparacaoRepository, PreparacaoRepository>();

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(InsumoIndiretoProfile));
builder.Services.AddAutoMapper(typeof(MateriaPrimaProfile));
builder.Services.AddAutoMapper(typeof(ProdutoProfile));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
