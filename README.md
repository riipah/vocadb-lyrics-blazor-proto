# VocaDB lyrics display [Blazor](https://github.com/aspnet/Blazor) proto

[Demo here](https://lyrics-proto.vocadb.net/).

Just a simple proto I did for testing the [Blazor framework](https://github.com/aspnet/Blazor). Frontend code written in C#, running in browser with WebAssembly.

## Notes

* Data binding (bind attribute) and event listeners cannot be combined on the same element at the moment. I would've used onchange together with bind for the search box, but not possible.
* The built-in JSON serializer doesn't seem to be able to convert between JavaScript and C# style property naming, so properties are named in JavaScript style (starting with lowercase letter).