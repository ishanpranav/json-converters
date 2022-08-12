# A collection of `JsonConverter` classes
Although the new `System.Text.Json` APIs have robust serialization support for custom classes, they do not natively support many built-in .NET types. This repository\'s standalone [`JsonConverter<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1) implementations add support for some of the missing types.
## Converters
| Namespace            | Type | Kind | Converter | Example |
| -------------------- | ---- | ---- | --------- | ------- |
| `System.Globalization` | [`CultureInfo`](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo) | Class | `CultureInfoConverter` | `"en-US"` |
| `System.Net`           | [`IPAddress`](https://docs.microsoft.com/en-us/dotnet/api/system.net.ipaddress) | Class | `IPAddressConverter` | `"127.0.0.1"` |
| `System.Numerics` | [`Complex`](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex) | Struct | `ComplexConverter` | `{ "Real": -0.7269, "Imaginary": 0.1889 }` |

## License
This repository is licensed with the [MIT](LICENSE.txt) license.
