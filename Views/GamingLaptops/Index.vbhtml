@ModelType IEnumerable(Of ElectroStore2.GamingLaptop)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.RefreshRate_Hz)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ResponseTime_ms)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Laptop.Brand)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RefreshRate_Hz)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ResponseTime_ms)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Laptop.Brand)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.GamingLaptopID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.GamingLaptopID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.GamingLaptopID })
        </td>
    </tr>
Next

</table>
