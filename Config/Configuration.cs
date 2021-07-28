using LogicMonitor.Api;
using LogicMonitor.Api.Collectors;
using LogicMonitor.Api.Dashboards;
using LogicMonitor.Api.Devices;
using LogicMonitor.Api.Netscans;
using LogicMonitor.Api.Reports;
using LogicMonitor.Api.Users;
using LogicMonitor.Api.Websites;
using System.Collections.Generic;

namespace LogicMonitor.Provisioning.Config
{
	/// <summary>
	/// Application configuration, loaded from an appsettings.json file upon execution
	/// You can modify/extend this class and provide your own settings
	/// </summary>
	internal class Configuration
	{
		/// <summary>
		/// LogicMonitor credentials
		/// </summary>
		public LogicMonitorCredentials LogicMonitorCredentials { get; set; } = new();

		/// <summary>
		/// The mode (create = provisioning, delete = removal)
		/// </summary>
		public Mode Mode { get; set; }

		/// <summary>
		/// Variables to set for all groups where properties can apply
		/// </summary>
		public List<Property> Variables { get; set; } = new();

		/// <summary>
		/// The properties to set
		/// </summary>
		public List<Property> Properties { get; set; } = new();

		/// <summary>
		/// The Report structure to apply.
		/// Note that LogicMonitor does not support nesting here.
		/// </summary>
		public Structure<ReportGroup, Report> Reports { get; set; } = new();

		/// <summary>
		/// The NetScan structure to apply
		/// Note that LogicMonitor does not support nesting here.
		/// </summary>
		public Structure<NetscanGroup, Netscan> Netscans { get; set; } = new();

		/// <summary>
		/// The Collector structure to apply
		/// Note that LogicMonitor does not support nesting here.
		/// </summary>
		public Structure<CollectorGroup, Collector> Collectors { get; set; } = new();

		/// <summary>
		/// The Device structure to apply
		/// </summary>
		public Structure<DeviceGroup, Device> Devices { get; set; } = new();

		/// <summary>
		/// The Website structure to apply
		/// </summary>
		public Structure<WebsiteGroup, Website> Websites { get; set; } = new();

		/// <summary>
		/// The Dashboard structure to apply
		/// </summary>
		public Structure<DashboardGroup, Dashboard> Dashboards { get; set; } = new();

		/// <summary>
		/// The Role structure to apply
		/// Note that LogicMonitor does not support nesting here.
		/// </summary>
		public Structure<RoleGroup, Role> Roles { get; set; } = new();

		/// <summary>
		/// The User structure to apply
		/// Note that LogicMonitor does not support nesting here.
		/// </summary>
		public Structure<UserGroup, User> Users { get; set; } = new();
	}
}
