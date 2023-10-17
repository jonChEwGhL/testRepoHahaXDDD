using Application.Common.Options;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Graylog;
using Serilog.Sinks.Graylog.Core.Transport;
using Serilog.Sinks.SystemConsole.Themes;

public class Program
{
    static IWebHostEnvironment webhostEnvironment;
    public static void Main(string[] args)
    {
        IWebHostEnvironment webhostEnvironment;

        var builder = WebApplication.CreateBuilder(args);

        //builder.Configuration.AddJsonFile("appsettings.json", false, true);
        builder.Services.AddWebUIServices(builder.Configuration);



        using (var scope = builder.Services.BuildServiceProvider())
        {
            var graylogOptions = scope.GetRequiredService<IOptions<GraylogOptions>>().Value;
            webhostEnvironment = scope.GetRequiredService<IWebHostEnvironment>();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore.Authentication", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .Enrich.WithProperty("ApplicationName", webhostEnvironment.ApplicationName)
                .Enrich.WithProperty("Environment", webhostEnvironment.EnvironmentName)
                .WriteTo.Console(
                    outputTemplate:
                    "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}",
                    theme: AnsiConsoleTheme.Literate)
                .WriteTo.File(graylogOptions.LogPath + DateTime.Now.ToString("yyyyMMdd") + graylogOptions.FileFormat, fileSizeLimitBytes: null, retainedFileCountLimit: null)
                .WriteTo.Graylog(new GraylogSinkOptions
                {
                    HostnameOrAddress = graylogOptions.HostName,
                    Port = graylogOptions.Port ?? 12201,
                    TransportType = TransportType.Udp
                })
                .CreateLogger();

            builder.Services.AddLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.AddSerilog(dispose: true);
            });
        }

        var app = builder.Build();


        if (webhostEnvironment.EnvironmentName == Environments.Production)
        {
            app.UseHsts();
            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint($"v1/swagger.json", webhostEnvironment.ApplicationName));
        }

        if (webhostEnvironment.EnvironmentName == Environments.Staging)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint($"v1/swagger.json", webhostEnvironment.ApplicationName));
        }

        if (webhostEnvironment.EnvironmentName == Environments.Development)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/v1/swagger.json", webhostEnvironment.ApplicationName));
        }

        app.UseSwagger();

        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", webhostEnvironment.ApplicationName));

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseCors(builderCors => builderCors.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        // 
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHealthChecks("/health", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
        });

        try
        {
            Log.Information($"{webhostEnvironment.EnvironmentName} - {webhostEnvironment.ApplicationName} is starting web host");
            app.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Host terminated unexpectedly");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}