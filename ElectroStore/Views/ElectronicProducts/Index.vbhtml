@ModelType IEnumerable(Of ElectroStore2.ElectronicProduct)
@Code
ViewData("Title") = "Index"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
<h2>All the products</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Price)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Rating)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Quantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Colour)
        </th>

        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Price)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Rating)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Quantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Colour)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ProductID}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ProductID})
        </td>
    </tr>
Next

</table>
