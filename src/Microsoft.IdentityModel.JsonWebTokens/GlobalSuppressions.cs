﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Previously released as non-static", Scope = "member", Target = "~P:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.TokenType")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Previously released as non-static", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.EncryptToken(System.String,Microsoft.IdentityModel.Tokens.EncryptingCredentials)~System.String")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Previously released as non-static", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.EncryptToken(System.String,Microsoft.IdentityModel.Tokens.EncryptingCredentials,System.String)~System.String")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Previously released as non-static", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.EncryptToken(System.String,Microsoft.IdentityModel.Tokens.EncryptingCredentials,System.String,System.Collections.Generic.IDictionary{System.String,System.Object})~System.String")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Previously released as non-static", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.EncryptToken(System.String,Microsoft.IdentityModel.Tokens.EncryptingCredentials,System.Collections.Generic.IDictionary{System.String,System.Object})~System.String")]
[assembly: SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible", Justification = "Previously released as visible field", Scope = "member", Target = "~F:Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJws")]
[assembly: SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible", Justification = "Previously released as visible field", Scope = "member", Target = "~F:Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJwe")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Previously released as non-static/inheritable", Scope = "type", Target = "~T:Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as Try method", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebToken.TryGetPayloadValue``1(System.String,``0@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as Try method", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebToken.TryGetHeaderValue``1(System.String,``0@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is written to a string", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.DecryptToken(Microsoft.IdentityModel.JsonWebTokens.JsonWebToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~System.String")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is returned as a result", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateToken(System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~Microsoft.IdentityModel.Tokens.TokenValidationResult")]
[assembly: SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "Has no fields or properties", Scope = "type", Target = "~T:Microsoft.IdentityModel.JsonWebTokens.JwtHeaderParameterNames")]
[assembly: SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "Has no fields or properties", Scope = "type", Target = "~T:Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is written to a string", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.GetContentEncryptionKeys(Microsoft.IdentityModel.JsonWebTokens.JsonWebToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~System.Collections.Generic.IEnumerable{Microsoft.IdentityModel.Tokens.SecurityKey}")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is written to a string", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.DecryptJwtToken(Microsoft.IdentityModel.Tokens.SecurityToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters,Microsoft.IdentityModel.JsonWebTokens.JwtTokenDecryptionParameters)~System.String")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is written to a string", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateSignature(System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters,Microsoft.IdentityModel.Tokens.BaseConfiguration)~Microsoft.IdentityModel.JsonWebTokens.JsonWebToken")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is returned in the TokenValidationResult", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateJWE(Microsoft.IdentityModel.JsonWebTokens.JsonWebToken,System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters,Microsoft.IdentityModel.Tokens.BaseConfiguration)~Microsoft.IdentityModel.Tokens.TokenValidationResult")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is returned in the TokenValidationResult", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateJWS(System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters,Microsoft.IdentityModel.Tokens.BaseConfiguration)~Microsoft.IdentityModel.Tokens.TokenValidationResult")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is returned in the TokenValidationResult", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateTokenAsync(System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~System.Threading.Tasks.Task{Microsoft.IdentityModel.Tokens.TokenValidationResult}")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is written to a string", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateTokenAsync(System.String,Microsoft.IdentityModel.JsonWebTokens.JsonWebToken,System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~System.Threading.Tasks.Task{Microsoft.IdentityModel.Tokens.TokenValidationResult}")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "Vendored component", Scope = "module")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is written to a string", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.CreateTokenPrivate(System.String,Microsoft.IdentityModel.Tokens.SigningCredentials,Microsoft.IdentityModel.Tokens.EncryptingCredentials,System.String,System.Collections.Generic.IDictionary{System.String,System.Object},System.Collections.Generic.IDictionary{System.String,System.Object},System.String)~System.String")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.ValidateSignature(System.String,Microsoft.IdentityModel.JsonWebTokens.JsonWebToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters,Microsoft.IdentityModel.Tokens.BaseConfiguration)~Microsoft.IdentityModel.JsonWebTokens.JsonWebToken")]
