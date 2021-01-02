@ModelType IEnumerable(Of ElectroStore2.Refrigerator)
@Code
    ViewData("Title") = "Index"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Refrigerators</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Name)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Volume)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.SpecialCompartiments)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.NoOfShelves)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.KitchenAppliance.ElectronicProduct.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Volume)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.SpecialCompartiments)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NoOfShelves)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.RefrigeratorID}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.RefrigeratorID})
                </td>
            </tr>
        Next

    </table>


    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
