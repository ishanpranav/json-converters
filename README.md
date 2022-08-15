# A collection of `JsonConverter` classes
Although the new `System.Text.Json` APIs have robust serialization support for custom classes, they do not natively support many built-in .NET types. This repository\'s standalone [`JsonConverter<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1) implementations add support for some of the missing types.
## Converters
| Namespace            | Type | Kind | Converter | Example |
| -------------------- | ---- | ---- | --------- | ------- |
| `System.Globalization` | [`CultureInfo`](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo) | Class | `JsonCultureInfoConverter` | `"en-US"` |
| `System.Net`           | [`IPAddress`](https://docs.microsoft.com/en-us/dotnet/api/system.net.ipaddress) | Class | `JsonIPAddressConverter` | `"127.0.0.1"` |
| `System.Numerics` | [`Complex`](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex) | Struct | `JsonComplexConverter` | `{ "Real": -0.7269, "Imaginary": 0.1889 }` |

## Adapters
| Adapter | Description |
| ------- | ----------- |
| `TypeConverterJsonConverterAdapter` | Adds support for the [`TypeConverterAttribute`](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.typeconverterattribute). Source: [dotnet/runtime #1761](https://github.com/dotnet/runtime/issues/1761).

## License
This repository is licensed with the [MIT](LICENSE.txt) license.
