# Additional converters for System.Text.Json
This repository contains custom JSON converters to serialize built-in .NET types that the new [System.Text.Json](https://www.nuget.org/packages/System.Text.Json) APIs do not natively support.
## Converters
| Namespace            | Type | Kind | Converter | Example |
| -------------------- | ---- | ---- | --------- | ------- |
| System.Globalization | [CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo) | Class | [CultureInfoConverter](CultureInfoConverter.cs) | `"en-US"` |
| System.Net           | [IPAddress](https://docs.microsoft.com/en-us/dotnet/api/system.net.ipaddress) | Class | [IPAddressConverter](IPAddressConverter.cs) | `"127.0.0.1"` |
| System.Numerics | [Complex](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex) | Struct | [ComplexConverter](ComplexConverter.cs) | `{ "real": -0.7269, "imaginary": 0.1889 }` |
## License
This repository is licensed with the [MIT](LICENSE.txt) license.
