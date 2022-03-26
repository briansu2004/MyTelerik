# MyTelerik

My Telerik

## Telerik UI for Blazor

Telerik.UI.for.Blazor 3.1.0

### AutoComplete

Error:

```
Error (active) RZ9991 The attribute names could not be inferred from bind attribute 'bind-Value'. Bind attributes should be of the form 'bind' or 'bind-value' along with their corresponding optional parameters like 'bind-value:event', 'bind:format' etc.
```

Solution:

`@bind-Value="@SelectedProduct"`

to

`bind-value="@SelectedProduct"`

Error:

```
There is no registered service of type 'System.Net.Http.HttpClient'.
```

Solution:

```
builder.Services.AddScoped(sp => new HttpClient {});
```
