﻿using System;
using System.IO;
using System.Text;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.SignalR;
using Abp.AspNetZeroCore.Licensing;
using Abp.AspNetZeroCore.Web;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.IO;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Caching.Redis;
using Abp.Timing;
using Abp.Zero.Configuration;
using Castle.Core.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using TimeTracking.Authentication.TwoFactor;
using TimeTracking.Chat;
using TimeTracking.Configuration;
using TimeTracking.EntityFrameworkCore;
using TimeTracking.Startup;
using TimeTracking.Web.Authentication.JwtBearer;
using TimeTracking.Web.Authentication.TwoFactor;
using TimeTracking.Web.Chat.SignalR;
using TimeTracking.Web.Configuration;
using TimeTracking.Web.DashboardCustomization;

namespace TimeTracking.Web
{
    [DependsOn(
        typeof(TimeTrackingApplicationModule),
        typeof(TimeTrackingEntityFrameworkCoreModule),
        typeof(AbpAspNetZeroCoreWebModule),
        typeof(AbpAspNetCoreSignalRModule),
        typeof(TimeTrackingGraphQLModule),
        typeof(AbpRedisCacheModule), //AbpRedisCacheModule dependency (and Abp.RedisCache nuget package) can be removed if not using Redis cache
        typeof(AbpHangfireAspNetCoreModule) //AbpHangfireModule dependency (and Abp.Hangfire.AspNetCore nuget package) can be removed if not using Hangfire
    )]
    public class TimeTrackingWebCoreModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TimeTrackingWebCoreModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            //Set default connection string
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TimeTrackingConsts.ConnectionStringName
            );

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(TimeTrackingApplicationModule).GetAssembly()
                );

            Configuration.Caching.Configure(TwoFactorCodeCacheItem.CacheName,
                cache =>
                {
                    cache.DefaultSlidingExpireTime = TwoFactorCodeCacheItem.DefaultSlidingExpireTime;
                });

            if (_appConfiguration["Authentication:JwtBearer:IsEnabled"] != null &&
                bool.Parse(_appConfiguration["Authentication:JwtBearer:IsEnabled"]))
            {
                ConfigureTokenAuth();
            }

            Configuration.ReplaceService<IAppConfigurationAccessor, AppConfigurationAccessor>();

            Configuration.ReplaceService<IAppConfigurationWriter, AppConfigurationWriter>();

            //Uncomment this line to use Hangfire instead of default background job manager (remember also to uncomment related lines in Startup.cs file(s)).
            //Configuration.BackgroundJobs.UseHangfire();

            //Uncomment this line to use Redis cache instead of in-memory cache.
            //See app.config for Redis configuration and connection string
            //Configuration.Caching.UseRedis(options =>
            //{
            //    options.ConnectionString = _appConfiguration["Abp:RedisCache:ConnectionString"];
            //    options.DatabaseId = _appConfiguration.GetValue<int>("Abp:RedisCache:DatabaseId");
            //});
        }

        private void ConfigureTokenAuth()
        {
            IocManager.Register<TokenAuthConfiguration>();
            var tokenAuthConfig = IocManager.Resolve<TokenAuthConfiguration>();

            tokenAuthConfig.SecurityKey =
                new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(_appConfiguration["Authentication:JwtBearer:SecurityKey"]));
            tokenAuthConfig.Issuer = _appConfiguration["Authentication:JwtBearer:Issuer"];
            tokenAuthConfig.Audience = _appConfiguration["Authentication:JwtBearer:Audience"];
            tokenAuthConfig.SigningCredentials =
                new SigningCredentials(tokenAuthConfig.SecurityKey, SecurityAlgorithms.HmacSha256);
            tokenAuthConfig.AccessTokenExpiration = AppConsts.AccessTokenExpiration;
            tokenAuthConfig.RefreshTokenExpiration = AppConsts.RefreshTokenExpiration;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingWebCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            SetAppFolders();

            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TimeTrackingWebCoreModule).Assembly);
        }

        private void SetAppFolders()
        {
            var appFolders = IocManager.Resolve<AppFolders>();

            appFolders.SampleProfileImagesFolder = Path.Combine(_env.WebRootPath,
                $"Common{Path.DirectorySeparatorChar}Images{Path.DirectorySeparatorChar}SampleProfilePics");
            appFolders.WebLogsFolder = Path.Combine(_env.ContentRootPath, $"App_Data{Path.DirectorySeparatorChar}Logs");
        }
    }
}
