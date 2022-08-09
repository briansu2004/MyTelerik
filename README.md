# MyTelerik

My Telerik

## Telerik UI for MAUI Blazor

Telerik.UI.for.Blazor 3.1.0

### How to add Telerik UI for MAUI Blazor compnoents (.Net 6)

1. NuGet

One of these ways -

- VS Add NuGet packages

- `nuget.config`

- `dotnet` CLI

2. Add to VS Blazor projects

https://docs.telerik.com/blazor-ui/getting-started/server-blazor

`~/Pages/_Layout.cshtml`

```
<head>
    <script src="_content/Telerik.UI.for.Blazor.Trial/js/telerik-blazor.js" defer></script>
    <link rel="stylesheet" href="_content/Telerik.UI.for.Blazor.Trial/css/kendo-theme-default/all.css" />
</head>
```

`~/Program.cs`

```
builder.Services.AddScoped(sp => new HttpClient {});
builder.Services.AddTelerikBlazor();
```

`~/_Imports.razor`

```
@using Telerik.Blazor
@using Telerik.Blazor.Components
```

`~/Shared/TelerikLayout.razor`

```
@inherits LayoutComponentBase

<TelerikRootComponent>
    @Body
</TelerikRootComponent>
```

`~/Shared/MainLayout.razor`

```
@layout TelerikLayout
@inherits LayoutComponentBase
```

3. Add Telerik Components to the Views

```
<TelerikAutoComplete ...>
...
```

## Telerik UI for Blazor

Telerik.UI.for.Blazor 3.1.0

### How to add Telerik UI for Blazor compnoents (.Net 6)

1. NuGet

One of these ways -

- VS Add NuGet packages

- `nuget.config`

- `dotnet` CLI

2. Add to VS Blazor projects

https://docs.telerik.com/blazor-ui/getting-started/server-blazor

`~/Pages/_Layout.cshtml`

```
<head>
    <script src="_content/Telerik.UI.for.Blazor.Trial/js/telerik-blazor.js" defer></script>
    <link rel="stylesheet" href="_content/Telerik.UI.for.Blazor.Trial/css/kendo-theme-default/all.css" />
</head>
```

`~/Program.cs`

```
builder.Services.AddScoped(sp => new HttpClient {});
builder.Services.AddTelerikBlazor();
```

`~/_Imports.razor`

```
@using Telerik.Blazor
@using Telerik.Blazor.Components
```

`~/Shared/TelerikLayout.razor`

```
@inherits LayoutComponentBase

<TelerikRootComponent>
    @Body
</TelerikRootComponent>
```

`~/Shared/MainLayout.razor`

```
@layout TelerikLayout
@inherits LayoutComponentBase
```

3. Add Telerik Components to the Views

```
<TelerikAutoComplete ...>
...
```

### AutoComplete

#### Usage

To use a Telerik AutoComplete for Blazor

- add the TelerikAutoComplete tag
- populate its Data property with the collection of items you want in the dropdown
- (optional) enable features like filtering and clear button

AutoComplete two-way value binding, main features and simple data binding.

### Catches

`@bind-Value="@SelectedProduct"`

not

`bind-value="@SelectedProduct"`

## To fork
