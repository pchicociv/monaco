﻿using Monaco.Template.Backend.Application.Features.Company.Commands;

namespace Monaco.Template.Backend.Api.DTOs.Extensions;

public static class CompanyExtensions
{
	public static CompanyCreateCommand MapCreateCommand(this CompanyCreateEditDto value) =>
		new(value.Name!,
			value.Email!,
			value.WebSiteUrl!,
			value.Street,
			value.City,
			value.County,
			value.PostCode,
			value.CountryId);

	public static CompanyEditCommand MapEditCommand(this CompanyCreateEditDto value, Guid id) =>
		new(id,
			value.Name!,
			value.Email!,
			value.WebSiteUrl!,
			value.Street,
			value.City,
			value.County,
			value.PostCode,
			value.CountryId);
}