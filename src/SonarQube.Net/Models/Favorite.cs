﻿using Newtonsoft.Json;
using SonarQube.Net.Common.Converters;

namespace SonarQube.Net.Models
{
	public class Favorite : KeyedName
	{
		public string Organization { get; set; }

		[JsonConverter(typeof(ComponentQualifiersConverter))]
		public ComponentQualifiers Qualifier { get; set; }
	}
}
