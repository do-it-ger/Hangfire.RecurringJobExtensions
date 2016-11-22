﻿using System.Collections.Generic;

namespace Hangfire.RecurringJobExtensions.Configuration
{
	/// <summary>
	/// Provides configuration for <see cref="RecurringJobInfo"/> for Hangfire.
	/// </summary>
	public interface IConfigurationProvider
	{
		/// <summary>
		/// Loads configuration values from the source represented by this <see cref="IConfigurationProvider"/>.
		/// </summary>
		/// <returns></returns>
		IEnumerable<RecurringJobInfo> Load();
	}
}
