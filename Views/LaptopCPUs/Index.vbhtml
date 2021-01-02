@ModelType IEnumerable(Of ElectroStore2.LaptopCPU)
@Code
ViewData("Title") = "Index"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Brand)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NumberOfCores)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Frequency_mHz)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Brand)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NumberOfCores)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Frequency_mHz)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.LaptopCPUID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.LaptopCPUID })
        </td>
    </tr>
Next

</table>
