@ModelType IEnumerable(Of ElectroStore2.LaptopGPU)
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
            @Html.DisplayNameFor(Function(model) model.Type)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DedicatedMemory_GB)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Brand)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Type)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DedicatedMemory_GB)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.LaptopGPUID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.LaptopGPUID })
        </td>
    </tr>
Next

</table>
