using System;
using Service.Helpers;
using Service.Services.Interfaces;
using Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Service
{
	public static class DependencyInjection
	{
		public static  IServiceCollection AddServiceLayer(this IServiceCollection services)
		{


            services.AddAutoMapper(typeof(MappingProfile));
			services.AddScoped<IGroupService, GroupService>();
			return services;
		}
	}
}

